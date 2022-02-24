using Microsoft.AspNetCore.Mvc;
using MvCproyekt.BLL.Services.IServices;
using MvCproyekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IUserService _userService;
        public RegisterController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> CreatedUser(UserToAddDTO userToAddDTO)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }
           
            await _userService.Add(userToAddDTO);
            return RedirectToAction("Index","Login");

        }
    }
}
