using System;
using System.Collections.Generic;
using System.Diagnostics;
using EasyBeer.Models;
using Microsoft.AspNetCore.Mvc;

namespace EasyBeer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var users = new List<User>();
            users.Add(new User() { Name = "Douglas Menddes"});
            users.Add(new User() { Name = "Felipe Tofoli"});
            users.Add(new User() { Name = "Mayara Mendes"});
            return View(users);
        }
        
        public IActionResult Error(int id)
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}