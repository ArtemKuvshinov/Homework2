using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework2.Common.Swagger;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Homework2.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Homework2.Models.DTO;

namespace Homework2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ApiExplorerSettings(GroupName = SwaggerDocParts.Buildings)]
    public class BuildingController : ControllerBase
    {
        private readonly ILogger<BuildingController> _logger;
        private readonly IBuildingService _buildingService;

        /// <summary>
        /// Инициализирует экземпляр <see cref="BuildingController"/> c помощью DI.
        /// </summary>
        /// <param name="buildingService">Сервис "Здание".</param>
        /// <param name="logger">Логгер.</param>
        public BuildingController(IBuildingService buildingService, ILogger<BuildingController> logger)
        {
            _buildingService = buildingService;
            _logger = logger;
        }


        /// <summary>
        /// Получение перечня зданий
        /// </summary>
        /// <returns>Коллекция сущностей "Здание".</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BuildingDTO>))]
        public IActionResult Get()
        {
            _logger.LogInformation("Buildings/Get was requested.");
            var response = _buildingService.GetAsync();
            return Ok(response);
        }


        /// <summary>
        /// Удаляет здание из исписка
        /// </summary>
        /// <param name="id"></param>        
        //[HttpDelete("{id}")]
        //public IActionResult Delete(long id)
        //{
        //  //  var todo = _buildingService.GetAsync().

        //    //if (todo == null)
        //    //{
        //    //    return NotFound();
        //    //}

        //    //_context.TodoItems.Remove(todo);
        //    //_context.SaveChanges();

        //    return NoContent();
        //}


    }
}
