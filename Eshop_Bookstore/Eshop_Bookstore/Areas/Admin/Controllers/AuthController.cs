using Eshop_Bookstore.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eshop_Bookstore.Models;
namespace Eshop_Bookstore.Areas.Admin.Controllers
{
    public class AuthController : Controller
    {
        private readonly Eshop_BookstoreContext _context;
        [Area("Admin")]

        [HttpGet]
        public IActionResult Login()
        {
            ViewBag.ErrorMessage = "";
            return View();
        }
        [HttpPost]
             public IActionResult LoginAdmin(FormCollection field) {
            string error = "";
            ViewBag.ErrorMessage = "";
            string username = field["username"];
            string password = field["password"];
          //  Account ac = _context.Accounts.Where(m => m.IsAdmin = 1  ).First;
            return View("Login");
        }
    }
}
