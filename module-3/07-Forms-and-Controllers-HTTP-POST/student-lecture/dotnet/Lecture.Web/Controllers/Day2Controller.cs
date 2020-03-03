using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lecture.Web.Models;
using Lecture.Web.DAL;

namespace Lecture.Web.Controllers
{
    public class Day2Controller : Controller

    {

        private ICityDAO cityDAO;

            public Day2Controller(ICityDAO icd)
        {
            cityDAO = icd;
        }
        public IActionResult AddCity()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddCity(City city)
        {
            cityDAO.AddCity(city);
            return RedirectToAction("SearchResults", "" +
                "")
        }


    }

    



}