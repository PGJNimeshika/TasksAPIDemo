using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TasksAPI.Services;

namespace TasksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDosController : ControllerBase
    {
        private IToDoRepository _toDoServices; // Inside the class private property 

        public ToDosController(IToDoRepository repository)
        {
            _toDoServices = repository;
        }

        [HttpGet("{id?}")]
        public IActionResult GetToDoList(int? id) // ? allow null 
        {
            // var Mytodos = AlltoDos(); // get all to do list and display in end point
            //var Mytodos = AlltoDos().Where(t => t.Id == id); // get the data base only using one parameter

            var Mytodos = _toDoServices.AlltoDos();

            // Display mentione id details only 
            if (id is null)
            return Ok(Mytodos);

            // else Display all to do list
            Mytodos = Mytodos.Where(t => t.Id == id).ToList();
            return Ok(Mytodos);
        }

    }
}
