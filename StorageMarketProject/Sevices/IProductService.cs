using StorageMarketProjectAPI.DtoModels;

namespace StorageMarketProjectAPI.Sevices
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetProductsAsync();
        Task<ProductDto> GetSingleProductAsync(int productId);
        Task<ProductDto> CreateProductAsync(ProductDto productToCreate);
        Task<ProductDto> UpdateProductAsync(ProductDto productToUpdate);
        Task<ProductDto> DeleteProductAsync(int productId);
    }
}
