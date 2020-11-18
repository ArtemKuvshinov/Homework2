using System;
using System.Collections.Generic;
using System.Text;
using Homework2.Models.DTO;
using Homework2.Services.Interfaces;
using AutoMapper;
using Homework2.DataBase.Mocks;

namespace Homework2.Services.Services
{
    /// <summary>
    /// Сервис для работы с данными "Здание"
    /// </summary>
    /// <inheritdoc cref="IBuildingService"/>
    public class BuildingService : IBuildingService
    {
        private readonly IMapper _mapper;

        /// <summary>
        /// Пооключение автомаппера через DI
        /// </summary>
        /// <param name="mapper"></param>
        public BuildingService(IMapper mapper)
        {
            _mapper = mapper;
        }

        /// <summary>
        /// Получет коллекцию объектов BuildingDTO
        /// </summary>
        /// <returns>Коллекция объектов BuildingDTO</returns>
        public IEnumerable<BuildingDTO> GetAsync()
        {
            var buildings = BuildingMock.GetBuilding();
            var response = _mapper.Map<IEnumerable<BuildingDTO>>(buildings); //mapping DM to DTO
            return response;
        }
    }
}
