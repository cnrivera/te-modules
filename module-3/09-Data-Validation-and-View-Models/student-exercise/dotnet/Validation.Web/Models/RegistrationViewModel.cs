using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validation.Web.Models
{
    public class RegistrationViewModel
    {
        [Display(Name = "First Name")]
        [Required, StringLength(20)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required, StringLength(20)]
        public string LastName { get; set; }

        [Display(Name = "E-mail")]
        [Required, EmailAddress]
        public string NewEmail { get; set; }

        [Display(Name = "Confirm E-mail")]
        [Required, EmailAddress, Compare("NewEmail", ErrorMessage = "Password does not match")]
        public string ConfirmEmail { get; set; }

        [Display(Name = "Password")]
        [Required, StringLength(50, MinimumLength=8), DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Display(Name = "Confirm Password")]
        [Required, DataType(DataType.Password), Compare("NewPassword", ErrorMessage = "Password does not match")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Birthday")]
        [Required]
        public DateTime Birthday { get; set; }

        [Display(Name = "# of Tickets")]
        [Required, Range(1, 10, ErrorMessage = "Please enter amount between 1 and 10")]
        public int NumTickets { get; set; }
    }
}