using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.Models
{
    public class SectorToUpdateDTO
    {
        public int SectorId { get; set; }
        [Required(ErrorMessage = "Enter sectorname")]
        public string SectorName { get; set; }
        public int DepartmentId { get; set; }
        public List<DepartmentToListDTO> Departments { get; set; }
    }
}
