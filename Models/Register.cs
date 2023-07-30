using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Xunit.Sdk;

namespace RegistrationForm.Models
{
    public class Register
    {
        [Required]
        [Display(Name = "Enter Username")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Enter Age")]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Enter Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Enter Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Enter your Gender")]
        public string Gender { get; set; }
        
        [Required]
        [Display(Name = "Enter marital status")]
        public string Status { get; set; }

    }
}