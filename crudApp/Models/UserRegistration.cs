using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace crudApp.Models
{
    public class UserRegistration
    {
      [Key]
        public int iUserId { get; set; }
        [Required]
        [Display(Name = "First Name:-")]
        public string sFirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string sLastName { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string  sGender { get; set; }

    }
}