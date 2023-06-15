namespace StorageMarketProjectAPI.Models
{
    public class Product
    {
        public int ProductId { get; internal set; }
        public string? ProductName { get; internal set; }
        public decimal? ProductCost { get; internal set; }
    }
}
