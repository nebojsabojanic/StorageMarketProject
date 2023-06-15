using StorageMarketProjectAPI.DtoModels;

namespace StorageMarketProjectAPI.Sevices
{
    public interface IStorageService
    {
        Task<List<StorageDto>> GetStoragesAsync();
        Task<StorageDto> GetSingleStorageAsync(int storageId);
        Task<StorageDto> CreateStorageAsync(StorageDto storageToCreate);
        Task<StorageDto> UpdateStorageAsync(StorageDto storageToUpdate);
        Task<StorageDto> DeleteStorageAsync(int storageId);
    }
}
