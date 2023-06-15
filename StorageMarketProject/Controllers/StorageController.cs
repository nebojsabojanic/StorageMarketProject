using Microsoft.AspNetCore.Mvc;
using StorageMarketProjectAPI.DtoModels;
using StorageMarketProjectAPI.Sevices;

namespace StorageMarketProjectAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StorageController : ControllerBase
    {
        private readonly IStorageService _StorageService;
        public StorageController(IStorageService StorageService)
        {
            _StorageService = StorageService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetStorages()
        {
            try
            {
                var Storages = await _StorageService.GetStoragesAsync();

                return Ok(Storages);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        [HttpGet("{singleStorageId:int}")]
        public async Task<IActionResult> GetSingleStorage(int singleStorageId)
        {
            try
            {
                var singleStorage = await _StorageService.GetSingleStorageAsync(singleStorageId);

                if (singleStorage == null)
                {
                    return NotFound();
                }

                return Ok(StorageDto.MapFromStorageDto(singleStorage));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateStorage([FromBody] StorageDto storageDto)
        {
            try
            {
                var storageToCreate = await _StorageService.CreateStorageAsync(storageDto);

                var storages = await _StorageService.GetStoragesAsync();

                var result = storages.SingleOrDefault(storage => storage.StorageId == storageToCreate.StorageId);

                if (result != null)
                {
                    throw new ArgumentException("Storage with that ID already exist in the database");
                }

                return Ok(storageToCreate);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateStorage([FromBody] StorageDto storageDto)
        {
            try
            {
                StorageDto storageToUpdate = await _StorageService.UpdateStorageAsync(storageDto);

                List<StorageDto> storages = await _StorageService.GetStoragesAsync();

                StorageDto? result = storages.SingleOrDefault(storage => storage.StorageId == storageToUpdate.StorageId);

                if (result == null)
                {
                    throw new ArgumentException("Storage does not exist in the database");
                }

                return Ok(storageToUpdate);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteStorage(int id)
        {
            try
            {
                StorageDto storageToDelete = await _StorageService.GetSingleStorageAsync(id);

                if (storageToDelete == null)
                {
                    throw new ArgumentException($"Storage with ID = {id} not found!");
                }

                return Ok(await _StorageService.DeleteStorageAsync(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
