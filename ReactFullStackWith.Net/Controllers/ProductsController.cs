using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReactFullStackWith.Net.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = new List<string> { "Laptop", "Mobile", "Tablet" };
            return Ok(products);
        }
    }
}
