using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BonnePratique.Models;

namespace BonnePratique.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Somme()
        {
            string conclusion;
            List<Account> accounts = new List<Account>();
            accounts.Add(new Account { amount = 10000 });
            accounts.Add(new Account { amount = 80 });
            accounts.Add(new Account { amount = 910000 });
            double sum = accounts.Sum(m => m.amount);
            if (sum > 10000000)
            {
                conclusion = "You earn too much money";
            }
            else
            {
                conclusion = "You should ask for a salary raise";
            }
            return View("Account",conclusion);
        }
    }
}
