using StorageMarketProjectAPI.DtoModels;

namespace StorageMarketProjectAPI.Sevices
{
    public interface IStateOfStorageService
    {
        Task<List<StateOfStorageDto>> GetStateOfStoragesAsync();
        Task<StateOfStorageDto> GetSingleStateOfStorageAsync(int stateOfStorageId);
        Task<StateOfStorageDto> CreateStateOfStorageAsync(StateOfStorageDto stateOfStorageToCreate);
        Task<StateOfStorageDto> UpdateStateOfStorageAsync(StateOfStorageDto stateOfStorageToUpdate);
        Task<StateOfStorageDto> DeleteStateOfStorageAsync(int stateOfStorageId);
    }
}
