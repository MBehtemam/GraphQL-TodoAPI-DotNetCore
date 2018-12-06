using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using TodoAPI.Models;

namespace TodoAPI.Data
{
    public class TodoRepository : ITodoRepository
    {
        private List<Todo> _todos;
        public TodoRepository()
        {
            _todos = new List<Todo>(){
                new Todo(){Id=1,Title="Buy Milk",Completed=false},
                new Todo(){Id=2,Title="Buy Chocolate",Completed=false},
                new Todo(){Id=3,Title="Meet CEO",Completed=true},
                new Todo(){Id=4,Title="Cook dinner",Completed=false},
                new Todo(){Id=5,Title="Buy Shoes",Completed=true}
            };
        }
        public Task<Todo> GetTodoById(int id)
        {
            return Task.FromResult(_todos.FirstOrDefault(x => x.Id == id));
        }
        public Task<List<Todo>> GetTodos()
        {
            return Task.FromResult(_todos);
        }
    }
}