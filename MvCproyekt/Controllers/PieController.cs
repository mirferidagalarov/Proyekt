using Microsoft.AspNetCore.Mvc;
using MvCproyekt.DAL.DatabaseContext;
using MvCproyekt.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.Controllers
{
    public class PieController : Controller
    {
        private readonly DataContext _dataContext;
        public PieController(DataContext dataContext)
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

            cs = _dataContext.Employees
                    .GroupBy(p => p.Department.DepartmentName)
                   .Select(g => new Chart { proname = g.Key.ToString(), count = g.Count() }).ToList();

            return cs;
        }
    }
}
