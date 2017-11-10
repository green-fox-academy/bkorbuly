using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoDB.Repositories;
using ToDoDB.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoDB.Controllers
{
    public class ToDoController : Controller
    {
        ToDoRepository ToDoRepositroy;
        public ToDoController(ToDoRepository toDoRepository)
        {
            ToDoRepositroy = toDoRepository;
        }
        [HttpGet]
        [Route("/todo")]
        public IActionResult List(bool isActive)
        {
            if (isActive == true)
                return View(ToDoRepositroy.GetListIsDone());
            return RedirectToAction("List");
        }

        [Route("/")]
        [Route("/list")]
        public IActionResult List()
        {
            return View(ToDoRepositroy.GetList());
        }

        [Route("/add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/add")]
        public IActionResult Add(ToDo toDo)
        {
            ToDoRepositroy.AddTodo(toDo);
            return RedirectToAction("List");
        }
        [HttpPost]
        [Route("/remove/{id}")]
        public IActionResult List(int id)
        {
            return RedirectToAction("List");
        }
    }
}
