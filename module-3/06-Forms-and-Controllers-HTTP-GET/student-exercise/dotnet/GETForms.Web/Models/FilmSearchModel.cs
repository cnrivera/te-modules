using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GETForms.Web.Models
{
    public class FilmSearchModel
    {

        [Display(Name = "Minimum Length: ")]
        public int MinLength { get; set; }
      
        [Display(Name = "Maximum Length: ")]
        public int MaxLength { get; set; }

        [Display(Name = "Genre: ")]
        public string Genre { get; set; }
    }


}
