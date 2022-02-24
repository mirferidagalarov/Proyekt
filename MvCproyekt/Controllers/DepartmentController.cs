using Microsoft.AspNetCore.Mvc;
using MvCproyekt.BLL.Services.IServices;
using MvCproyekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        public async Task<IActionResult> Index()
        {
            List<DepartmentToListDTO> departments = await _departmentService.Get();
            return View(departments);
        }
        public IActionResult AddDepartment()
        {
            return View();
        }

        public async Task<IActionResult> Add(DepartmentToAddDTO departmentToAddDTO)
        {
            if (!ModelState.IsValid)
            {
                return View("AddDepartment");
            }
            await _departmentService.Add(departmentToAddDTO);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateDepartment(int id)
        {
            DepartmentToUpdateDTO department = await _departmentService.GetId(id);
            return View(department);
        }
        public async Task<IActionResult> Update(DepartmentToUpdateDTO departmentToUpdateDTO)
        {
            if (!ModelState.IsValid)
            {
                return View("UpdateDepartment");
            }
            await _departmentService.Update(departmentToUpdateDTO);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _departmentService.Delete(id);
            return RedirectToAction("Index");
        }



    }
}
