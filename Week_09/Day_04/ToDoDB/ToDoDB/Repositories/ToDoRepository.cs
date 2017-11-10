using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoDB.Entities;
using ToDoDB.Models;

namespace ToDoDB.Repositories
{
    public class ToDoRepository
    {
        ToDoContext ToDoContext;
        public ToDoRepository(ToDoContext toDoContext)
        {
            ToDoContext = toDoContext;
        }

        public List<ToDo> GetList()
        {
            return ToDoContext.ToDos.ToList();
        }

        public List<ToDo> GetListIsDone()
        {
            return GetList().Where(x => x.IsDone == false).ToList();
        }

        public void AddTodo(ToDo toDo)
        {
            ToDoContext.ToDos.Add(toDo);
            ToDoContext.SaveChanges();
        }
    }
}
