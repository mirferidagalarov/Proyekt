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
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;
        private readonly ISectorService _sectorService;
        private readonly IPositionService _positionService;

        public EmployeeController(IEmployeeService employeeService, IDepartmentService departmentService, ISectorService sectorService, IPositionService positionService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
            _sectorService = sectorService;
            _positionService = positionService;
           
        }
        public async Task<IActionResult> Index()
        {
            List<EmployeeToListDTO> employees = await _employeeService.Get();         
            return View(employees);
        }

        public async Task<IActionResult>AddEmployee()
        {
           
            List<DepartmentToListDTO> departmentToListDTOs = await _departmentService.Get();
            List<SectorToListDTO> sectorToListDTOs = await _sectorService.Get();
            List<PositionToListDTO> positionToListDTOs = await _positionService.Get();
            EmployeeToAddDTO employeeToAddDTO = new EmployeeToAddDTO();         
            employeeToAddDTO.Positions = positionToListDTOs;
            employeeToAddDTO.Departments = departmentToListDTOs;
            employeeToAddDTO.Sectors = sectorToListDTOs;            
            return View(employeeToAddDTO);
        }

        public async Task<IActionResult> Add(EmployeeToAddDTO employeeToAddDTO)
        {
            if (!ModelState.IsValid)
            {
                List<DepartmentToListDTO> departmentToListDTOs = await _departmentService.Get();
                List<SectorToListDTO> sectorToListDTOs = await _sectorService.Get();
                List<PositionToListDTO> positionToListDTOs = await _positionService.Get();
                employeeToAddDTO.Positions = positionToListDTOs;
                employeeToAddDTO.Departments = departmentToListDTOs;
                employeeToAddDTO.Sectors = sectorToListDTOs;
                return View("AddEmployee", employeeToAddDTO);
            }
            await _employeeService.Add(employeeToAddDTO);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateEmployee(int id)
        {
            List<DepartmentToListDTO> departmentToListDTOs = await _departmentService.Get();
            List<SectorToListDTO> sectorToListDTOs = await _sectorService.Get();
            List<PositionToListDTO> positionToListDTOs = await _positionService.Get();
            EmployeeToUpdateDTO employee = await _employeeService.GetId(id);
            employee.Departments = departmentToListDTOs;
            employee.Sectors = sectorToListDTOs;
            employee.Positions = positionToListDTOs;
            return View(employee);
        }

        public async Task<IActionResult> Update(EmployeeToUpdateDTO employeeToUpdateDTO)
        {
            if (!ModelState.IsValid)
            {
                List<DepartmentToListDTO> departmentToListDTOs = await _departmentService.Get();
                List<SectorToListDTO> sectorToListDTOs = await _sectorService.Get();
                List<PositionToListDTO> positionToListDTOs = await _positionService.Get();
                EmployeeToUpdateDTO employee = await _employeeService.GetId(employeeToUpdateDTO.EmployeeId);
                employee.Departments = departmentToListDTOs;
                employee.Sectors = sectorToListDTOs;
                employee.Positions = positionToListDTOs;
                return View("UpdateEmployee", employee);
            }
            await _employeeService.Update(employeeToUpdateDTO);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _employeeService.Delete(id);
            return RedirectToAction("Index");
        }


      

    }
}
