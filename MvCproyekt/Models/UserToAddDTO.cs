using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.Models
{
    public class UserToAddDTO
    {
        [Required(ErrorMessage = "Enter name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Enter surname")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Enter Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter password")]
        public string Password { get; set; }
    }
}
