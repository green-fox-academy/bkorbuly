using Exercise_01_TODO.Entity;
using Exercise_01_TODO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_01_TODO.Repositories
{
    public class TodoRepository
    {
        TodoContext TodoContext;
        public TodoRepository(TodoContext todoContext)
        {
            TodoContext = todoContext;
        }

        public List<ToDo> GetList()
        {
            return TodoContext.Todos.ToList();
        }
    }
}
