using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
