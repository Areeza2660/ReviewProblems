using System;
using System.Collections.Generic;

namespace OOPBasedTodoApp
{
  
    public class TodoItem
    {
        public string action { get; set; }
        public bool done { get; set; }
    }

    public class TodoList
    {
       
        public List<TodoItem> Items { get; } = new List<TodoItem>();

        public void Add(TodoItem item) => Items.Add(item);

   
        public List<TodoItem> getTodos() => Items.FindAll(t => !t.done);

    
        public void MarkActionDone(string action)
        {
            var item = Items.Find(t =>
                string.Equals(t.action, action, StringComparison.OrdinalIgnoreCase));
            if (item != null) item.done = true;
        }

        public override string ToString() =>
            string.Join(Environment.NewLine, getTodos().ConvertAll(t => t.action));
    }

    class Program
    {
        static void Main(string[] args)
        {
        
            var tl = new TodoList();
            tl.Add(new TodoItem { action = "Grocery", done = false });
            tl.Add(new TodoItem { action = "Gym",     done = false });
            tl.MarkActionDone("Gym");
            foreach (var todo in tl.getTodos()) Console.WriteLine(todo.action);
         

       
       
        }
    }
}