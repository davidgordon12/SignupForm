using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Username")]
        [Required(ErrorMessage = "Please provide a valid Username")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 20 characters.")]
        public string Username { get; set; }

        [Display(Name = "E-Mail")]
        [Required(ErrorMessage = "Please provide a valid E-Mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Confirm E-Mail")]
        [Compare("Email", ErrorMessage = "E-Mails do not match.")]
        public string ConfirmEmail { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please provide a valid password")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Password must be between 10 and 100 characters.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
