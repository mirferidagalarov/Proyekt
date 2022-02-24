using MvCproyekt.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.Models
{
    public class SectorToListDTO
    {
        public int SectorId { get; set; }
        public string SectorName { get; set; }
        public int CountryId { get; set; }
        public Department Department { get; set; }
       
    }
}
