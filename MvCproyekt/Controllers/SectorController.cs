using Microsoft.AspNetCore.Mvc;
using MvCproyekt.BLL.Services.IServices;
using MvCproyekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.Controllers
{
    public class SectorController : Controller
    {
        private readonly ISectorService _sectorService;
        private readonly IDepartmentService _departmentService;
        public SectorController(ISectorService sectorService, IDepartmentService departmentService)
        {
            _sectorService = sectorService;
            _departmentService = departmentService;
        }
        public async Task<IActionResult> Index()
        {
            List<SectorToListDTO> sectors = await _sectorService.Get();                     
            return View(sectors);
        }

        public async Task<IActionResult> AddSector()
        {
            List<DepartmentToListDTO> departmentToListDTOs = await _departmentService.Get();
            SectorToAddDTO sectorToAddDTO = new SectorToAddDTO();
            sectorToAddDTO.Departments = departmentToListDTOs;
            return View(sectorToAddDTO);
        }

        public async Task<IActionResult> Add(SectorToAddDTO sectorToAddDTO)
        {
            
            if (!ModelState.IsValid)
            {
                List<DepartmentToListDTO> departmentToListDTOs = await _departmentService.Get();              
                sectorToAddDTO.Departments = departmentToListDTOs;
                return View("AddSector", sectorToAddDTO);
            }
            
            await _sectorService.Add(sectorToAddDTO);            
            return RedirectToAction("Index");          

        }

        public async Task<IActionResult> UpdateSector(int id)
        {
            List<DepartmentToListDTO> departmentToListDTOs = await _departmentService.Get();            
            SectorToUpdateDTO sector = await _sectorService.GetId(id);
            sector.Departments = departmentToListDTOs;          
            return View(sector);
        }

        public async Task<IActionResult> Update(SectorToUpdateDTO sectorToUpdateDTO)
        {
            
            if (!ModelState.IsValid)
            {
                List<DepartmentToListDTO> departmentToListDTOs = await _departmentService.Get();
                SectorToUpdateDTO sector = await _sectorService.GetId(sectorToUpdateDTO.SectorId);
                sector.Departments = departmentToListDTOs;
                return View("UpdateSector", sector);
            }
            
            await _sectorService.Update(sectorToUpdateDTO);
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> Delete(int id)
        {
            await _sectorService.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
