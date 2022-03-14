using Microsoft.AspNetCore.Mvc;
using MvCproyekt.BLL.Services.IServices;
using MvCproyekt.DAL.DatabaseContext;
using MvCproyekt.Entities;
using MvCproyekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.Controllers
{
    public class PasswordController : Controller
    {
        private readonly DataContext _dataContext;
        private readonly IUserService _userService;
        public PasswordController(DataContext dataContext, IUserService userService)
        {
            _dataContext = dataContext;
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }
 
        public async Task<IActionResult> PasswordUpdate(UserToUpdateDTO userToUpdateDTO)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }
            var yoxla = _dataContext.Users.SingleOrDefault(m => m.Email == userToUpdateDTO.Email);
            if (yoxla!=null)
            {
                if (userToUpdateDTO.Password == userToUpdateDTO.ConfirmPassword)
                {
                    yoxla.Password = userToUpdateDTO.Password;
                    await _userService.Update(yoxla);
                    return RedirectToAction("Index", "Login");
                }
            }
            
            return View();

        }




    }
}
