using Microsoft.AspNetCore.Mvc;
using MvCproyekt.BLL.Services.IServices;
using MvCproyekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.Controllers
{
    public class SalaryController : Controller
    {
        private readonly ISalaryService _salaryService;
        private readonly IMonthService _monthService;
        private readonly IYearService _yearService;
       

        public SalaryController(ISalaryService salaryService, IMonthService monthService, IYearService yearService)
        {
            _salaryService = salaryService;
            _monthService = monthService;
            _yearService = yearService;
           
          
        }
        public async Task<IActionResult> Index(int id)
        {
            List<SalaryToListDTO> salarys =await _salaryService.Get();
            ViewBag.EmpId = id;
            return View(salarys);
        }

        public async Task<IActionResult> AddSalary(int id)
        {
          
            List<MonthToListDTO>  monthToListDTOs  = await _monthService.Get();
            List<YearToListDTO> yearToListDTOs = await _yearService.Get();
            SalaryToAddDTO salaryToAddDTO = new SalaryToAddDTO();
            salaryToAddDTO.Month = monthToListDTOs;
            salaryToAddDTO.Year = yearToListDTOs;        
            salaryToAddDTO.EmployeeId = id;
            return View(salaryToAddDTO);
        }
        public async Task<IActionResult> Add(SalaryToAddDTO  salaryToAddDTO)
        {

            await _salaryService.Add(salaryToAddDTO);
            return RedirectToAction("Index");

        }
    }
}
