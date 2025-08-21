

using HRWebAPI.Entities;
using Microsoft.AspNetCore.Mvc;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return new List<Product>()
            {
                new Product { Id = 1, Title = "Smart laptop ", Price = 5000.23f, Description = "smart laptop" },
                new Product { Id = 2, Title = "smartphone", Price = 12.99f, Description = "communication device" },
                new Product { Id = 3, Title = "Tablet", Price = 15.99f, Description = "Handy device" }


            };
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return new Product { Id = 3, Title = "Tablet", Price = 15.99f, Description = "Handy device" };
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] Product product)
        {
            //here you would add product to a database or a collection
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
