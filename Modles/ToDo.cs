﻿namespace TasksAPI.Modles
{
    public class ToDo
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime DueDate { get; set; }
        public ToDoStatus status { get; set;} // New ,Progress , Completed

    }

}
