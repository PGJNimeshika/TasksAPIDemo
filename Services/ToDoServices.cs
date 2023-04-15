using TasksAPI.Modles;

namespace TasksAPI.Services
{
    public class ToDoServices
    {
        public List<ToDo> AlltoDos()
        {
            var todos = new List<ToDo>();

            var todo1 = new ToDo
            {
                Id = 1,
                Title = "Title 01",
                Description = "Description of Tittle 01",
                Created = DateTime.Now,
                DueDate = DateTime.Now.AddDays(5),
                status = ToDoStatus.Inprogress
            };
            todos.Add(todo1); // Add to the todo list 

            var todo2 = new ToDo
            {
                Id = 2,
                Title = "Title 02",
                Description = "Description of Tittle 02",
                Created = DateTime.Now,
                DueDate = DateTime.Now.AddDays(5),
                status = ToDoStatus.New
            };
            todos.Add(todo2);

            var todo3 = new ToDo
            {
                Id = 3,
                Title = "Title 03",
                Description = "Description of Tittle 03",
                Created = DateTime.Now,
                DueDate = DateTime.Now.AddDays(5),
                status = ToDoStatus.Completed
            };

            todos.Add(todo3);

            return todos; // terun list 
        }
    }
}
