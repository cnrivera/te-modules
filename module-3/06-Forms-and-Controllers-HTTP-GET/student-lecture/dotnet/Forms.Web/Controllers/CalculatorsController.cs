﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Forms.Web.Controllers
{
    public class CalculatorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Result(CalculatorModel cm)
        {
            return View(cm); 
        }
    }
}