using MvCproyekt.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.Models
{
    public class SalaryToListDTO
    {
        public int SalaryId { get; set; }
        public double Salary { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        public Month Month { get; set; }     
        public int MonthId { get; set; }
        public Years Year { get; set; }       
        public int YearsId { get; set; }
    }
}
