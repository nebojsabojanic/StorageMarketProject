namespace StorageMarketProjectAPI.Models
{
    public class StateOfStorage
    {
        public int StateOfStorageId { get; internal set; }
        public int ProductId { get; internal set; }
        public int StorageId { get; internal set; }
        public int? Quantity { get; internal set; }
    }
}
