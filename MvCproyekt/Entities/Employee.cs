using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public DateTime DateofBirth { get; set; }
        public Department Department { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Sector Sector { get; set; }
        [ForeignKey("Sector")]
        public int SectorId { get; set; }
        public Position Position { get; set; }
        [ForeignKey("Position")]
        public int PositionId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
