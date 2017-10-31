using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exercise_01_TODO.Models;
using Exercise_01_TODO.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Exercise_01_TODO
{
    public class TodoController : Controller
    {
        TodoRepository TodoRepository;

        public TodoController(TodoRepository todoRepository)
        {
            TodoRepository = todoRepository;
        }
        [Route("/todo")]
        public IActionResult Index()
        {
            return View();
        }
        
        [Route("/")]
        [Route("/list")]
        public IActionResult List()
        {
            return View(TodoRepository.GetList());
        }
    }
}
