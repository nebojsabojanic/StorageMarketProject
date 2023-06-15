using Microsoft.EntityFrameworkCore;
using StorageMarketProjectAPI.DtoModels;
using StorageMarketProjectAPI.Models;
using StorageMarketProjectAPI.Models.DbContexts;

namespace StorageMarketProjectAPI.Sevices
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _dbContext;
        public ProductService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ProductDto>> GetProductsAsync()
        {
            var Products = await _dbContext.Products2.ToListAsync();

            var ProductDTOs = new List<ProductDto>();

            foreach (var Product in Products)
            {
                ProductDTOs.Add(ProductDto.MapFromProduct(Product));
            }

            return ProductDTOs;
        }

        public async Task<ProductDto> GetSingleProductAsync(int productId)
        {
            var ProductFromDb = await _dbContext.Products2.SingleOrDefaultAsync(product => product.ProductId == productId);

            return ProductDto.MapFromProduct(ProductFromDb);
        }

        public async Task<ProductDto> CreateProductAsync(ProductDto ProductToCreate)
        {
            var Product = ProductDto.MapFromProductDto(ProductToCreate);

            var ProductFromDb = await _dbContext.Products2.SingleOrDefaultAsync(product => product.ProductId == Product.ProductId);

            if (ProductFromDb != null)
            {
                return ProductDto.MapFromProduct(ProductFromDb);
            }
            else
            {
                await _dbContext.Products2.AddAsync(Product);
                await _dbContext.SaveChangesAsync();
                return ProductDto.MapFromProduct(Product);
            }
        }

        public async Task<ProductDto> UpdateProductAsync(ProductDto ProductToUpdate)
        {
            var Product = ProductDto.MapFromProductDto(ProductToUpdate);

            var ProductFromDb = await _dbContext.Products2.SingleOrDefaultAsync(product => product.ProductId == Product.ProductId);

            if (ProductFromDb != null)
            {
                if (Product.ProductName != null)
                {
                    ProductFromDb.ProductName = Product.ProductName;
                }
                if (Product.ProductCost != null)
                {
                    ProductFromDb.ProductCost = Product.ProductCost;
                }

                await _dbContext.SaveChangesAsync();
                return ProductDto.MapFromProduct(ProductFromDb);
            }

            return null;
        }

        public async Task<ProductDto> DeleteProductAsync(int ProductToDelete)
        {
            var ProductFromDb = await _dbContext.Products2.FirstOrDefaultAsync(product => product.ProductId == ProductToDelete);

            if (ProductFromDb != null)
            {
                _dbContext.Products2.Remove(ProductFromDb);
                await _dbContext.SaveChangesAsync();
                return ProductDto.MapFromProduct(ProductFromDb);
            }

            return null;
        }
    }
}
