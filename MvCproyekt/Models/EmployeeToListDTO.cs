using Microsoft.AspNetCore.Http;
using MvCproyekt.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.Models
{
    public class EmployeeToListDTO
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public string ImagePath { get; set; }
        public double Salary { get; set; }
        public string DateofBirth { get; set; }
        public int DepartmentId { get; set; }
        public int SectorId { get; set; }
        public int PositionId { get; set; }
        public Department Department { get; set; }             
        public Sector Sector { get; set; }            
        public Position Position { get; set; }
      


    }
}
