using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.Models
{
    public class UserToListDTO
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email does not database")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password does not database")]
        public string Password { get; set; }
    }
}
