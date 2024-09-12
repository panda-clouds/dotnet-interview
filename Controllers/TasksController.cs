using autoChecker.Database;
using dotnet_interview.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnet_interview.Controllers
{
    [ApiController]
    [Route("api/Tasks")]
    public class TasksController: ControllerBase
    {
       private readonly ApplicationDbContext _context;
        public TasksController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("CreateTask")]
        public async Task<ActionResult> CreateTask([FromBody] TaskItem task){
            if(task != null){
                await _context.Tasks.AddAsync(task);
                _context.SaveChanges();
                return Ok(task);
            }
            return BadRequest();            
        }

        [HttpGet("MarkTaskComplete/{id}")]
        public async Task<ActionResult> MarkTaskComplete(Guid id){
            var task = await _context.Tasks.FirstOrDefaultAsync(t => t.Id == id);
            task.completed = true;
            _context.Tasks.Update(task);
            _context.SaveChanges();
            return Ok(task);
        }

        [HttpGet("MarkTaskUnComplete/{id}")]
        public async Task<ActionResult> MarkTaskUnComplete(Guid id){
            var task = await _context.Tasks.FirstOrDefaultAsync(t => t.Id == id);
            task.completed = false;
            _context.Tasks.Update(task);
            _context.SaveChanges();
            return Ok(task);
        }

        [HttpGet("GetTasks/{id}")]
        public async Task<ActionResult> GetAllTasks(Guid id){
            var tasks = await _context.Tasks.Where(t => t.UserId == id).ToListAsync();
            return Ok(tasks);
        }


        [HttpDelete]
        public ActionResult DeleteTask(Guid id){
            var task = _context.Tasks.FirstOrDefault(t => t.Id == id);
            if(task != null){
                _context.Tasks.Remove(task);
                  _context.SaveChanges();
                return Ok();
            }
            return BadRequest("Not Found");
        }
    }
}