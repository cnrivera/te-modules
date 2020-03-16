using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingListAPI.Models;
using ShoppingListAPI.Services;

namespace ShoppingListAPI.Controllers
{
    [Route("api/groceries")]
    [ApiController]
    public class GroceriesController : ControllerBase
    {
        private IDataAccessLayer<Item> dal;

        public GroceriesController(IDataAccessLayer<Item> dal)
        {
            this.dal = dal;
        }

        [HttpGet]
        public List<Item> GetAll()
        {

            return dal.GetAll();
        }

        [HttpGet("{id}",Name="Get")]
        public ActionResult<Item>Get(int id)
        {
            var grocery = dal.Get(id);
            if (grocery != null)
            {
                return grocery;
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult Add([FromBody] Item item)

        {
            dal.Add(item);

            return CreatedAtRoute("Get", new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public ActionResult Update(Item item)
        {
            var existingGrocery = dal.Get(item.Id);

            if (existingGrocery == null)
            {
                return NotFound();
            }

            existingGrocery.name = item.name;
            existingGrocery.completed = item.completed;

            dal.Update(existingGrocery);

            return NoContent();

        }

        [HttpDelete("{id}")]

        public ActionResult Delete(int id)
        {
            var grocery = dal.Get(id);
            if (grocery == null)
            {
                return NotFound();
            }
            dal.Delete(id);
            return NoContent();

        }

    }
}