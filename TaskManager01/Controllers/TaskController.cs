using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager01.Data;
using TaskManager01.Models;
using TaskEntity = TaskManager01.Models.Entities.Task;
namespace TaskManager01.Controllers
{
    [Route("TaskManagement/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;

        public TasksController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetAllTasks()
        {
            var allTasks = _dbContext.Tasks.ToList();
            return Ok(allTasks);
        }
        [HttpPost]
        public IActionResult AddTask(AddTaskDto addTaskDto)
        {
            var taskentity = new TaskEntity()
            {
                Title = addTaskDto.Title,
                Description = addTaskDto.Description,
                DueDate = addTaskDto.DueDate,
                Priority = addTaskDto.Priority,
                Assignee = addTaskDto.Assignee,
                Status = addTaskDto.Status,
                CategoryId = addTaskDto.CategoryID,
            };
            _dbContext.Tasks.Add(taskentity);
            _dbContext.SaveChanges();
            return Ok(taskentity);
        }
        [HttpGet]
        [Route("{TaskId:int}")]
        public IActionResult GetTaskbyId(int TaskId)
        {
            var task = _dbContext.Tasks.FirstOrDefault(t => t.TaskId == TaskId);
            if (task is null)
            {
                return NotFound();
            }
            return Ok(task);
        }
        [HttpPut]
        [Route("{TaskId:int}")]
        public IActionResult UpdateTask(int TaskId,UpdateTaskDto updatetaskdto)
        {
            var task = _dbContext.Tasks.FirstOrDefault(t => t.TaskId == TaskId);
            if (task is null)
            {
                return NotFound();

            }
            task.Title = updatetaskdto.Title;
            task.DueDate = updatetaskdto.DueDate;
            task.Status = updatetaskdto.Status;
            task.Assignee = updatetaskdto.Assignee;
            task.Priority = updatetaskdto.Priority;
            task.Description = updatetaskdto.Description;
            task.CategoryId = updatetaskdto.CategoryId;
            _dbContext.SaveChanges();
            return Ok(task);
        }
        [HttpDelete]
        [Route("{TaskId:int}")]
        public IActionResult DeleteTask(int TaskId)
        {
            var task = _dbContext.Tasks.FirstOrDefault(t => t.TaskId == TaskId);
            if (task is null)
            {
                return NotFound();
            }
            _dbContext.Tasks.Remove(task);
            _dbContext.SaveChanges();
            return Ok(task);


        }

    }
}
