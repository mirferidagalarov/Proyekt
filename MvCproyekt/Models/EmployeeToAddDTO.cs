using Microsoft.AspNetCore.Http;
using MvCproyekt.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.Models
{
    public class EmployeeToAddDTO
    {
        [Required(ErrorMessage = "Enter EmployeeName")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "Enter EmployeeSurname")]
        public string EmployeeSurname { get; set; }
        [Required(ErrorMessage = "Enter Salary")]
        public IFormFile ImagePath { get; set; }
        public double Salary { get; set; }
        public DateTime DateofBirth { get; set; }
        public List<DepartmentToListDTO> Departments { get; set; }        
        public int DepartmentId { get; set; }
        public List<SectorToListDTO> Sectors { get; set; }      
        public int SectorId { get; set; }
        public List<PositionToListDTO> Positions { get; set; }
        public int PositionId { get; set; }
    }
}
