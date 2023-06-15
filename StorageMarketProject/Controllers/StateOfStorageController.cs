using Microsoft.AspNetCore.Mvc;
using StorageMarketProjectAPI.DtoModels;
using StorageMarketProjectAPI.Sevices;

namespace StorageMarketProjectAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StateOfStorageController : ControllerBase
    {
        private readonly IStateOfStorageService _StateOfStorageService;
        public StateOfStorageController(IStateOfStorageService StateOfStorageService)
        {
            _StateOfStorageService = StateOfStorageService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetStateOfStorages()
        {
            try
            {
                var StateOfStorages = await _StateOfStorageService.GetStateOfStoragesAsync();

                return Ok(StateOfStorages);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("{singleId:int}")]
        public async Task<IActionResult> GetSingleStateOfStorages(int singleId)
        {
            try
            {
                var singleStateOfStorage = await _StateOfStorageService.GetSingleStateOfStorageAsync(singleId);

                if (singleStateOfStorage == null)
                {
                    return NotFound();
                }

                return Ok(StateOfStorageDto.MapFromStateOfStorageDto(singleStateOfStorage));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateStateOfStorage([FromBody] StateOfStorageDto stateOfStorageDto)
        {
            try
            {
                var stateOfStorageToCreate = await _StateOfStorageService.CreateStateOfStorageAsync(stateOfStorageDto);

                var stateOfStorages = await _StateOfStorageService.GetStateOfStoragesAsync();

                var result = stateOfStorages.SingleOrDefault(stateOfStorage => stateOfStorage.StateOfStorageId == stateOfStorageToCreate.StateOfStorageId);

                if (result != null)
                {
                    throw new ArgumentException("State Of Storage with that ID already exist in the database");
                }

                return Ok(stateOfStorageToCreate);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateStateOfStorage([FromBody] StateOfStorageDto stateOfStorageDto)
        {
            try
            {
                StateOfStorageDto stateOfStorageToUpdate = await _StateOfStorageService.UpdateStateOfStorageAsync(stateOfStorageDto);

                List<StateOfStorageDto> stateOfStorages = await _StateOfStorageService.GetStateOfStoragesAsync();

                StateOfStorageDto? result = stateOfStorages.SingleOrDefault(stateOfStorage => stateOfStorage.StateOfStorageId == stateOfStorageToUpdate.StateOfStorageId);

                if (result == null)
                {
                    throw new ArgumentException("State Of Storage does not exist in the database");
                }

                return Ok(stateOfStorageToUpdate);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{singleId:int}")]
        public async Task<IActionResult> DeleteStateOfStorage(int singleId)
        {
            try
            {
                StateOfStorageDto stateOfStorageToDelete = await _StateOfStorageService.GetSingleStateOfStorageAsync(singleId);

                if (stateOfStorageToDelete == null)
                {
                    throw new ArgumentException($"State Of Storage with ID = {singleId} not found!");
                }

                return Ok(await _StateOfStorageService.DeleteStateOfStorageAsync(singleId));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
