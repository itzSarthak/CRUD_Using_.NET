using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager01.Data;
using TaskManager01.Models;
using TaskManager01.Models.Entities;
namespace TaskManager01.Controllers
{
    [Route("TaskManagement/[controller]")]
    [ApiController]
    public class SubTaskController : ControllerBase
    {
        private readonly ApplicationDBContext dbContext;

        public SubTaskController(ApplicationDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetAllSubTasks()
        {
            var allSubTasks = dbContext.SubTasks.ToList();
            return Ok(allSubTasks);
        }
        [HttpPost]
        public IActionResult AddSubTask(AddSubTaskDto addSubTaskDto)
        {
            var subtask = new SubTask()
            {
                Title = addSubTaskDto.Title,
                SubTask_Description = addSubTaskDto.SubTask_Description,
                TaskId = addSubTaskDto.TaskId,
            };
            dbContext.SubTasks.Add(subtask);
            dbContext.SaveChanges();
            return Ok(subtask);
        }
        
        [HttpPut]
        [Route("{Id:int}")]
        public IActionResult UpdateSubTask(int Id, UpdateSubTaskDto updatesubtaskdto)
        {
            var subtask = dbContext.SubTasks.FirstOrDefault(t => t.Id == Id);
            if (subtask is null)
            {
                return NotFound();

            }
            subtask.SubTask_Description = updatesubtaskdto.SubTask_Description;
            subtask.TaskId = updatesubtaskdto.TaskId;
            subtask.Title = updatesubtaskdto.Title;
            dbContext.SaveChanges();
            return Ok(subtask);
        }
        [HttpDelete]
        [Route("{Id:int}")]
        public IActionResult DeleteSubTask(int Id)
        {
            var subtask = dbContext.SubTasks.FirstOrDefault(t => t.Id == Id);
            if (subtask is null)
            {
                return NotFound();
            }
            dbContext.SubTasks.Remove(subtask);
            dbContext.SaveChanges();
            return Ok(subtask);


        }

    }
}
