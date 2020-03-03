using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GETForms.Web.Models
{
    public class CustomerSearchModel
    {
        [Display(Name = "Name: ")]
        public string Name { get; set; }

        [Display(Name = "Sort By: ")]
        public string SortType { get; set; }

        public static List<SelectListItem> sortMethods = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Last Name", Value = "last_name" },
            new SelectListItem() { Text = "Email", Value = "email" },
            new SelectListItem() { Text = "Active", Value = "active" }
        };




    }
}
