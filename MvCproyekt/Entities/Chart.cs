using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.Entities
{
    public class Chart
    {
        [Key]
        public int Id { get; set; }
        public string proname { get; set; }
        public int stock { get; set; }
    }
}
