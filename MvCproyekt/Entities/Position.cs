using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.Entities
{
    public class Position
    {
        [Key]
        public int PositionId { get; set; }
        public string PositionName { get; set; }

    }
}
