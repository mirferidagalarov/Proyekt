using Microsoft.AspNetCore.Mvc;
using MvCproyekt.DAL.DatabaseContext;
using MvCproyekt.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.Controllers
{
    public class ChartController : Controller
    {
        private readonly DataContext _dataContext;
        public ChartController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VisualizeProductList()
        {
            return Json(DynamicProList());
        }


        public List<Chart> DynamicProList()
        {

            List<Chart> cs = new List<Chart>();

            cs = _dataContext.Departments.Select(x => new Chart
            {
                proname = x.DepartmentName,
                stock = x.StockAmount
            }).ToList();


            return cs;
        }

        public IActionResult Pie()
        {
            return View();
        }
        public IActionResult VisualizeProductList1()
        {
            return Json(DynamicProList1());
        }

        public List<Chart> DynamicProList1()
        {

            List<Chart> cs = new List<Chart>();

            cs = _dataContext.Employees.Select(x => new Chart
            {
                proname = x.Sector.SectorName,
                stock=x.SectorId
            }).ToList();


            return cs;
        }

    }


}

