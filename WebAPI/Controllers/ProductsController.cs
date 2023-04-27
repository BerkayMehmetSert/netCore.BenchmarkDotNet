using Microsoft.AspNetCore.Mvc;
using WebAPI.Application.Requests;
using WebAPI.Application.Responses;
using WebAPI.Application.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public async Task<ActionResult<ProductResponse>> CreateProduct(CreateProductRequest request)
        {
            var response = await _productService.CreateProduct(request);
            return StatusCode(StatusCodes.Status201Created, response);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ProductResponse>> UpdateProduct(Guid id, UpdateProductRequest request)
        {
            var response = await _productService.UpdateProduct(id, request);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ProductResponse>> DeleteProduct(Guid id)
        {
            var response = await _productService.DeleteProduct(id);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductResponse>> GetProductById(Guid id)
        {
            var response = await _productService.GetProductById(id);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductResponse>>> GetProducts()
        {
            var response = await _productService.GetProducts();
            return StatusCode(StatusCodes.Status200OK, response);
        }
    }
}
