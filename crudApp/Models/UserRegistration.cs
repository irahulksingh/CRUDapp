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
        [RegularExpression(@"^[a-zA-Z0-9'' ']+$", ErrorMessage = "Special character should not be entered")]
        [Display(Name = "First Name :")]
        public string sFirstName { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9'' ']+$", ErrorMessage = "Special character should not be entered")]
        [Display(Name = "Last Name :")]
        public string sLastName { get; set; }

        [Required]
        [Display(Name = "Gender :")]
        public string  sGender { get; set; }

        [Range(0, Int32.MaxValue, ErrorMessage = "Value should be greater than or equal to 0")]
        [Display(Name="Age :")]
        public int iAge { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email-Id : ")]
        [EmailAddress]
        public string sEmail { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone No. : ")]
        [Phone]
        public string sPhone { get; set; }

        [Display(Name= "Address : ")]
        public string sAddress { get; set; }

    }
}