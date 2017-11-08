using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Groot.Controllers
{
    public class GuardianController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/groot")]
        public IActionResult GrootJson(string message)
        {
            return Json(new { received = message, translated = "I am Groot!" });
        }
    }
}
