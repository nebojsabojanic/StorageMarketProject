using StorageMarketProjectAPI.Models;

namespace StorageMarketProjectAPI.DtoModels
{
    public class StateOfStorageDto
    {
        public int StateOfStorageId { get; set; }
        public int ProductId { get; set; }
        public int StorageId { get; set; }
        public int? Quantity { get; set; }

        public static StateOfStorageDto MapFromStateOfStorage(StateOfStorage StateOfStorage)
        {
            return new()
            {
                StateOfStorageId = StateOfStorage.StateOfStorageId,
                ProductId = StateOfStorage.ProductId,
                StorageId = StateOfStorage.StorageId,
                Quantity = (int)StateOfStorage.Quantity
            };
        }
        public static StateOfStorage MapFromStateOfStorageDto(StateOfStorageDto StateOfStorageDto)
        {
            return new()
            {
                StateOfStorageId = StateOfStorageDto.StateOfStorageId,
                ProductId = StateOfStorageDto.ProductId,
                StorageId = StateOfStorageDto.StorageId,
                Quantity = StateOfStorageDto.Quantity
            };
        }
    }
}
