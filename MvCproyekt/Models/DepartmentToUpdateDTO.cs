using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.Models
{
    public class DepartmentToUpdateDTO
    {
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Enter departmentname")]
        public string DepartmentName { get; set; }
    }
}
