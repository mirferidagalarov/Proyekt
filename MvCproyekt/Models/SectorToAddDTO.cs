using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.Models
{
    public class SectorToAddDTO
    {     
        public string SectorName { get; set; }
        public int DepartmentId { get; set; }
        public List<DepartmentToListDTO> Departments { get; set; }
    }
}
