using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Text.Json;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController : ControllerBase
    {
        List <Product> Products { get; set; }

        private readonly ILogger<StoreController> _logger;

        public StoreController(ILogger<StoreController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("store/add")]
        public IActionResult AddProduct(string productName, int cost, int stock)
        {
            Product product = new Product();
            product.Name = productName;
            product.Cost = cost;
            product.Stock = stock; //В методе апдейт продукт было бы  product.Stock += stock;
            Products.Add(product);
            return Ok();
        }
        [HttpDelete]
        [Route("store/add")]
        public IActionResult DeleteProduct(Product productName)
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
