using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Evolent.ViewModels
{
    public class ContactFormViewModel
    {
        [Required]
        public string showFirstName { get; set; }
        public string showLastName { get; set; }

        [Required]
        public string showEmail { get; set; }


        [Display(Name = "Mobile Number:")]
        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string showMobileNumber { get; set; }
        //public string showStatus { get; set; }

        public int showId { get; set; }
    }
}