using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exercise_01_Counter.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Exercise_01_Counter.Controllers
{
    public class HomeController : Controller
    {
        Counter counter;

        public HomeController(Counter counter)
        {
            this.counter = counter;
        }
        // GET: /<controller>/
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View(counter);
        }
        [HttpPost]
        [Route("/")]
        public IActionResult Increase()
        {
            counter.RaiseCounter();
            return RedirectToAction("Index");
        }
    }
}
