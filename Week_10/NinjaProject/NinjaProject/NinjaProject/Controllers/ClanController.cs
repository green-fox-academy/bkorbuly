using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NinjaProject.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NinjaProject.Controllers
{
    public class ClanController : Controller
    {
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Clan>), 200)]
        public Task<IActionResult> ReadAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
