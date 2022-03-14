using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "The email you've entered is incorrect")]
        public string Email { get; set; }
        [Required(ErrorMessage = "The email you've entered is incorrect")]
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool IsDeleted { get; set; }
    }
}
