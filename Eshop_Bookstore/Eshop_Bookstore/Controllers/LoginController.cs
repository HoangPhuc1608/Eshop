using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop_Bookstore.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            //return RedirectToAction("Index", "Login");
            return View();
        }
    }
}
