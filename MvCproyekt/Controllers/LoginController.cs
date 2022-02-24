using Microsoft.AspNetCore.Mvc;
using MvCproyekt.DAL.DatabaseContext;
using MvCproyekt.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.Controllers
{
    public class LoginController : Controller
    {
        private readonly DataContext _dataContext;
        public LoginController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(User user)
        {
           
            var yoxla = _dataContext.Users.FirstOrDefault(m => m.Email == user.Email && m.Password == user.Password);
            if (yoxla == null)
            {
                if (!ModelState.IsValid)
                {
                   
                }

                return View("Index");


            }
            return RedirectToAction("Index", "Dashboard");


        }

    }
}
