using Microsoft.EntityFrameworkCore;
using StorageMarketProjectAPI.DtoModels;
using StorageMarketProjectAPI.Models.DbContexts;

namespace StorageMarketProjectAPI.Sevices
{
    public class StateOfStorageService : IStateOfStorageService
    {
        private readonly AppDbContext _dbContext;
        public StateOfStorageService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<StateOfStorageDto>> GetStateOfStoragesAsync()
        {
            var StateOfStorages = await _dbContext.StatesOfStorages.ToListAsync();

            var StateOfStorageDTOs = new List<StateOfStorageDto>();

            foreach (var StateOfStorage in StateOfStorages)
            {
                StateOfStorageDTOs.Add(StateOfStorageDto.MapFromStateOfStorage(StateOfStorage));
            }

            return StateOfStorageDTOs;
        }

        public async Task<StateOfStorageDto> GetSingleStateOfStorageAsync(int stateOfStorageId)
        {
            var StateOfStorageFromDb = await _dbContext.StatesOfStorages.SingleOrDefaultAsync(stateOfStorage => stateOfStorage.StateOfStorageId == stateOfStorageId);

            return StateOfStorageDto.MapFromStateOfStorage(StateOfStorageFromDb);
        }

        public async Task<StateOfStorageDto> CreateStateOfStorageAsync(StateOfStorageDto StateOfStorageToCreate)
        {
            var AllStateOfStorages = await _dbContext.StatesOfStorages.ToListAsync();

            var StateOfStorage = StateOfStorageDto.MapFromStateOfStorageDto(StateOfStorageToCreate);

            var StateOfStorageFromDb = await _dbContext.StatesOfStorages.SingleOrDefaultAsync(sos => sos.StateOfStorageId == StateOfStorage.StateOfStorageId);

            if (StateOfStorageFromDb != null)
            {
                StateOfStorageFromDb.StateOfStorageId = StateOfStorage.StateOfStorageId;
                
                //List productIds and continue if find same ProductId
                /*foreach (var item in AllStateOfStorages)
                {
                    if (StateOfStorageFromDb.ProductId == item.ProductId)
                    {
                        break;
                    }
                }*/
                StateOfStorageFromDb.ProductId = StateOfStorage.ProductId;
                StateOfStorageFromDb.StorageId = StateOfStorage.StorageId;
                StateOfStorageFromDb.Quantity = StateOfStorage.Quantity;

                await _dbContext.SaveChangesAsync();

                return StateOfStorageDto.MapFromStateOfStorage(StateOfStorageFromDb);
            }
            else
            {
                await _dbContext.StatesOfStorages.AddAsync(StateOfStorage);
                await _dbContext.SaveChangesAsync();
                return StateOfStorageDto.MapFromStateOfStorage(StateOfStorage);
            }
        }

        public async Task<StateOfStorageDto> UpdateStateOfStorageAsync(StateOfStorageDto StateOfStorageToUpdate)
        {
            var StateOfStorage = StateOfStorageDto.MapFromStateOfStorageDto(StateOfStorageToUpdate);

            var StateOfStorageFromDb = await _dbContext.StatesOfStorages.SingleOrDefaultAsync(stateOfStorage => stateOfStorage.StateOfStorageId == StateOfStorage.StateOfStorageId);

            if (StateOfStorageFromDb != null)
            {
                if (StateOfStorage.ProductId != null)
                {
                    StateOfStorageFromDb.ProductId = StateOfStorage.ProductId;
                }
                if (StateOfStorage.StorageId != null )
                {
                    StateOfStorageFromDb.StorageId = StateOfStorage.StorageId;
                }
                if (StateOfStorage.Quantity != null)
                {
                    StateOfStorageFromDb.Quantity = StateOfStorage.Quantity;
                }

                await _dbContext.SaveChangesAsync();
                return StateOfStorageDto.MapFromStateOfStorage(StateOfStorageFromDb);
            }

            return null;
        }

        public async Task<StateOfStorageDto> DeleteStateOfStorageAsync(int StateOfStorageToDelete)
        {
            var StateOfStorageFromDb = await _dbContext.StatesOfStorages.FirstOrDefaultAsync(stateOfStorage => stateOfStorage.StateOfStorageId == StateOfStorageToDelete);

            if (StateOfStorageFromDb != null)
            {
                _dbContext.StatesOfStorages.Remove(StateOfStorageFromDb);
                await _dbContext.SaveChangesAsync();
                return StateOfStorageDto.MapFromStateOfStorage(StateOfStorageFromDb);
            }

            return null;
        }
    }
}
