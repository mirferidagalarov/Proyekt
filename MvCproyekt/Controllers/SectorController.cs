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
        public SectorController(ISectorService sectorService)
        {
            _sectorService = sectorService;
        }
        public async Task<IActionResult> Index()
        {
            List<SectorToListDTO> sectors = await _sectorService.Get();
            return View(sectors);
        }

        public IActionResult AddSector()
        {
            return View();
        }

        public async Task<IActionResult> Add(SectorToAddDTO sectorToAddDTO)
        {
            await _sectorService.Add(sectorToAddDTO);
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> UpdateSector(int id)
        {
            SectorToUpdateDTO sector = await _sectorService.GetId(id);
            return View(sector);


        }

        public async Task<IActionResult> Update(SectorToUpdateDTO sectorToUpdateDTO)
        {
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
