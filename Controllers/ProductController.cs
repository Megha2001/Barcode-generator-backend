using BarcodeFinal.Models;
using BarcodeFinal.Services;
using Microsoft.AspNetCore.Mvc;

namespace BarcodeFinal.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpPost("")]
        public IActionResult CreateProduct(ProductRequest productRequest)
        {
            var data = productService.CreateProduct(productRequest);
            return Ok(data);
        }

        [HttpPost("bulk")]
        public IActionResult CreateProducts(List<ProductRequest> productRequests)
        {
            var data = productService.CreateProducts(productRequests);
            return Ok(data);
        }
    }
}
