using App.Domain.core.Dtos.ProductDto;
using App.Domain.core.IAppService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace App.EndPoints.Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductAppService _productAppService;
        public ProductController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        [HttpPost("CreateProduct")]
        public async Task<IActionResult> CreateProduct(ProductAddDto product)
        {
            var msg = await _productAppService.CreateProduct(product);
            return Ok(msg);
        }

        [HttpPost("DeleteProduct/{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var msg = await _productAppService.DeleteProduct(id);
            return Ok(msg);
        }

        [HttpPost("EditProduct")]
        public async Task<IActionResult> EditProduct(ProductEditDto product)
        {
            var msg = await _productAppService.EditProduct(product);
            return Ok(msg);
        }

        [HttpGet("GetAllProducts")]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productAppService.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            var product = await _productAppService.GetById(id);
            return Ok(product);
        }
    }
}
