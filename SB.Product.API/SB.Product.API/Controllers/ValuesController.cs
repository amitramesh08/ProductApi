using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SB.ProductApi.Database;
using SB.ProductApi.Database.Repository;

namespace SB.Product.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ValuesController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<SB.ProductApi.Database.Models.Product>> Get()
        {
            return productRepository.GetProducts().ToList();
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
