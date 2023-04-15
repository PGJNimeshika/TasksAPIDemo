using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TasksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public IActionResult Tasks()
        {
            var Tasks = new string[] { "Tasl 01", "Task 02", "Task 03" };
            return Ok(Tasks);
        }

        [HttpPost]
        public IActionResult NewTasks()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTasks()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteTasks()
        {
            var somethingwrong = true;
            if (somethingwrong)
            return BadRequest();
            return Ok();
        }
    }
}
