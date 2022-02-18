using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Charts()
        {
            return View();
        }
        public IActionResult Tables()
        {
            return View();
        }
        public IActionResult StaticNavigation()
        {
            return View();
        }
        public IActionResult LightSidenav()
        {
            return View();
        }



    }
}
