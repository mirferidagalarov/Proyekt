using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.Entities
{
    public class Sector
    {
        [Key]
        public int SectorId { get; set; }
        public string SectorName { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
