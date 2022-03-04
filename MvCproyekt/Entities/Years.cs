using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.Entities
{
    public class Years
    {
        [Key]
        public int YearId { get; set; }
        public int Year { get; set; }
    }
}
