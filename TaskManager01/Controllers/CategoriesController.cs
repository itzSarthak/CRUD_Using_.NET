using Microsoft.AspNetCore.Mvc;
using TaskManager01.Data;
using TaskManager01.Models.Entities;
using TaskManager01.Models;
using System.Linq;

namespace TaskManager01.Controllers
{
    [Route("TaskManagement/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDBContext dbContext;

        public CategoriesController(ApplicationDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllCategories()
        {
            var categories = dbContext.Categories.ToList();
            return Ok(categories);
        }

        [HttpPost]
        public IActionResult AddCategory(AddCatDto addCatDto)
        {
            var category = new Category()
            {
                Name = addCatDto.Name,
                IsActive = addCatDto.IsActive,
                CreatedBy = addCatDto.CreatedBy,
                CreatedDate = addCatDto.CreatedDate,
            };
            dbContext.Categories.Add(category);
            dbContext.SaveChanges();
            return Ok(category);
        }

        [HttpPut]
        [Route("{CategoryId:int}")]
        public IActionResult UpdateCategory(int CategoryId, UpdateCatDto updateCatDto)
        {
            var existingCategory = dbContext.Categories.FirstOrDefault(c => c.CategoryId == CategoryId);
            if (existingCategory == null)
            {
                return NotFound();
            }
            existingCategory.Name = updateCatDto.Name;
            existingCategory.IsActive = updateCatDto.IsActive;
            existingCategory.CreatedBy = updateCatDto.CreatedBy;
            dbContext.SaveChanges();
            return Ok(existingCategory);
        }

        [HttpDelete]
        [Route("{CategoryId:int}")]
        public IActionResult DeleteCategory(int CategoryId)
        {
            var category = dbContext.Categories.FirstOrDefault(c => c.CategoryId == CategoryId);
            if (category == null)
            {
                return NotFound();
            }
            dbContext.Categories.Remove(category);
            dbContext.SaveChanges();
            return Ok(category);
        }
    }
}
