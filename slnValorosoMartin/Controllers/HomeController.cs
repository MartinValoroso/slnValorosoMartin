using Microsoft.AspNetCore.Mvc;
using System;

namespace OperaWebSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}

