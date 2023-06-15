using Microsoft.AspNetCore.Mvc;
using StorageMarketProjectAPI.DtoModels;
using StorageMarketProjectAPI.Sevices;

namespace StorageMarketProjectAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _ProductService;
        public ProductController(IProductService ProductService)
        {
            _ProductService = ProductService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetProducts()
        {
            try
            {
                var Products = await _ProductService.GetProductsAsync();

                return Ok(Products);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        [HttpGet("{singleProductId:int}")]
        public async Task<IActionResult> GetSingleProduct(int singleProductId)
        {
            try
            {
                var singleProduct = await _ProductService.GetSingleProductAsync(singleProductId);

                if (singleProduct == null)
                {
                    return NotFound();
                }

                return Ok(ProductDto.MapFromProductDto(singleProduct));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateProduct([FromBody] ProductDto productDto)
        {
            try
            {
                var productToCreate = await _ProductService.CreateProductAsync(productDto);

                var products = await _ProductService.GetProductsAsync();

                var result = products.SingleOrDefault(product => product.ProductId == productToCreate.ProductId);

                if (result != null)
                {
                    throw new ArgumentException("Product with that ID already exist in the database");
                }

                return Ok(productToCreate);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateProduct([FromBody] ProductDto productDto)
        {
            try
            {
                ProductDto productToUpdate = await _ProductService.UpdateProductAsync(productDto);

                List<ProductDto> products = await _ProductService.GetProductsAsync();

                ProductDto? result = products.SingleOrDefault(product => product.ProductId == productToUpdate.ProductId);

                if (result == null)
                {
                    throw new ArgumentException("Product does not exist in the database");
                }

                return Ok(productToUpdate);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            try
            {
                ProductDto productToDelete = await _ProductService.GetSingleProductAsync(id);

                if (productToDelete == null)
                {
                    throw new ArgumentException($"Product with ID = {id} not found!");
                }

                return Ok(await _ProductService.DeleteProductAsync(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
