using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductReviewsAPI.Services;
using ProductReviewsAPI.Models;

namespace ProductReviewsAPI.Controllers
{
    [Route("api/reviews")]
    [ApiController]
    public class ProductReviewsController : ControllerBase
    {

        private IDataAccessLayer<ProductReview> dal;
        public ProductReviewsController(IDataAccessLayer<ProductReview> dal)
        {

            this.dal = dal;
        }

        [HttpGet]
        public List<ProductReview> GetAll()
        {
            return dal.GetAll();
        }


        [HttpGet("{id}", Name = "GetProductReview")]
        public ActionResult<ProductReview> GetProductReview(int id)
        {
            var review = dal.Get(id);
            if (review != null)
            {
                return review;
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult Create([FromBody] ProductReview productReview)
        {
            dal.Add(productReview);

            return CreatedAtRoute("GetProductReview", new { id = productReview.Id }, productReview);

        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, ProductReview updatedReview)
        {
            var existingReview = dal.Get(id);

            if (existingReview==null)
            {
                return NotFound();
            }

            existingReview.Name = updatedReview.Name;
            existingReview.Title = updatedReview.Title;
            existingReview.Review = updatedReview.Review;

            dal.Update(existingReview);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var review = dal.Get(id);
            if (review == null)
            {
                return NotFound();
            }
            dal.Delete(id);
            return NoContent();
        }


    }
}