using Microsoft.EntityFrameworkCore;
using StorageMarketProjectAPI.DtoModels;
using StorageMarketProjectAPI.Models.DbContexts;

namespace StorageMarketProjectAPI.Sevices
{
    public class StorageService : IStorageService
    {
        private readonly AppDbContext _dbContext;
        public StorageService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<StorageDto>> GetStoragesAsync()
        {
            var Storages = await _dbContext.Storages.ToListAsync();

            var StorageDTOs = new List<StorageDto>();

            foreach (var Storage in Storages)
            {
                StorageDTOs.Add(StorageDto.MapFromStorage(Storage));
            }

            return StorageDTOs;
        }

        public async Task<StorageDto> GetSingleStorageAsync(int storageId)
        {
            var StorageFromDb = await _dbContext.Storages.SingleOrDefaultAsync(storage => storage.StorageId == storageId);

            return StorageDto.MapFromStorage(StorageFromDb);
        }

        public async Task<StorageDto> CreateStorageAsync(StorageDto StorageToCreate)
        {
            var Storage = StorageDto.MapFromStorageDto(StorageToCreate);

            var StorageFromDb = await _dbContext.Storages.SingleOrDefaultAsync(storage => storage.StorageId == Storage.StorageId);

            if (StorageFromDb != null)
            {
                return StorageDto.MapFromStorage(StorageFromDb);
            }
            else
            {
                await _dbContext.Storages.AddAsync(Storage);
                await _dbContext.SaveChangesAsync();
                return StorageDto.MapFromStorage(Storage);
            }
        }

        public async Task<StorageDto> UpdateStorageAsync(StorageDto StorageToUpdate)
        {
            var Storage = StorageDto.MapFromStorageDto(StorageToUpdate);

            var StorageFromDb = await _dbContext.Storages.SingleOrDefaultAsync(storage => storage.StorageId == Storage.StorageId);

            if (StorageFromDb != null)
            {
                if (Storage.StorageName != null)
                {
                    StorageFromDb.StorageName = Storage.StorageName;
                }
                if (Storage.KindOfStorage != null)
                {
                    StorageFromDb.KindOfStorage = Storage.KindOfStorage;
                }

                await _dbContext.SaveChangesAsync();
                return StorageDto.MapFromStorage(StorageFromDb);
            }

            return null;
        }

        public async Task<StorageDto> DeleteStorageAsync(int StorageToDelete)
        {
            var StorageFromDb = await _dbContext.Storages.FirstOrDefaultAsync(storage => storage.StorageId == StorageToDelete);

            if (StorageFromDb != null)
            {
                _dbContext.Storages.Remove(StorageFromDb);
                await _dbContext.SaveChangesAsync();
                return StorageDto.MapFromStorage(StorageFromDb);
            }

            return null;
        }
    }
}
