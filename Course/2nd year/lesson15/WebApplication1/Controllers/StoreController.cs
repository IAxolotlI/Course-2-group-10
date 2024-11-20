using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController : ControllerBase
    {
        List <string> Products { get; set; }

        private readonly ILogger<StoreController> _logger;

        public StoreController(ILogger<StoreController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("store/add")]
        public IActionResult AddProduct(string productName)
        {
            Products.Add(productName);
            return Ok();
        }
        [HttpDelete]
        [Route("store/add")]
        public IActionResult DeleteProduct(string productName)
        {
            Products.Remove(productName);
            return Ok();
        }
        [HttpGet]
        [Route("store/get")]
        public IActionResult GetProducts()
        {
            for (int i = 0; i < Products.Count; i++)
            {
                Console.WriteLine(Products[i]);
            }
            return Ok();
        }
    }
}
