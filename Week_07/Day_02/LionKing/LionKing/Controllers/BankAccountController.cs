using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LionKing.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LionKing.Controllers
{
    public class BankAccountController : Controller
    {
        // GET: /<controller>/
        [Route("Simba")]
        public IActionResult Index()
        {
            var bankAccountOne = new BankAccount()
            {
                Name = "Simba",
                Balance = 2000,
                Animaltype = "Lion",
                Currency = "Zebra"
            };
            return View(bankAccountOne);
        }

        [Route("List")]
        public IActionResult BankAccountList()
        {
            var bankAccountList = new BankAccountList();
            bankAccountList.FillList();
            return View(bankAccountList);
        }
    }
}
