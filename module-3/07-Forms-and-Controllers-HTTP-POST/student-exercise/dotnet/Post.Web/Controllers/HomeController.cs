using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Post.Web.DAL;
using Post.Web.Models;

namespace Post.Web.Controllers
{
    public class HomeController : Controller
    {
        private IReviewDAO dao;

        // GET: Home
        
        public HomeController(IReviewDAO reviewDAO)
        {
            this.dao = reviewDAO;
        }

        public IActionResult Index()
        {
            var reviewPost = dao.GetAllReviews();
            return View(reviewPost);
        }

        [HttpGet]
        public IActionResult NewReview()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewReview(Review newPost)
        {
            dao.SaveReview(newPost);
            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
