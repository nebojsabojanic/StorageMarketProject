using StorageMarketProjectAPI.Models;

namespace StorageMarketProjectAPI.DtoModels
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal? ProductCost { get; set; }

        public static ProductDto MapFromProduct(Product Product)
        {
            return new()
            {
                ProductId = Product.ProductId,
                ProductName = Product.ProductName,
                ProductCost = (decimal)Product.ProductCost
            };
        }
        public static Product MapFromProductDto(ProductDto Product)
        {
            return new()
            {
                ProductId = Product.ProductId,
                ProductName = Product.ProductName,
                ProductCost = Product.ProductCost
            };
        }
    }
}
