using StorageMarketProjectAPI.Models;

namespace StorageMarketProjectAPI.DtoModels
{
    public class StorageDto
    {
        public int StorageId { get; set; }
        public string? StorageName { get; set; }
        public string? KindOfStorage { get; set; }

        public static StorageDto MapFromStorage(Storage Storage)
        {
            return new()
            {
                StorageId = Storage.StorageId,
                StorageName = Storage.StorageName,
                KindOfStorage = Storage.KindOfStorage
            };
        }
        public static Storage MapFromStorageDto(StorageDto Storage)
        {
            return new()
            {
                StorageId = Storage.StorageId,
                StorageName = Storage.StorageName,
                KindOfStorage = Storage.KindOfStorage
            };
        }
    }
}
