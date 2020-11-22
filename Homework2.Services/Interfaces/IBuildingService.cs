using System.Collections.Generic;
using Homework2.Models.DTO;
using Homework2.DataBase.Domain;

namespace Homework2.Services.Interfaces
{
    /// <summary>
    /// Интерфейс для сервиса "Здание"
    /// </summary>
   public interface IBuildingService
    {
        IEnumerable<BuildingDTO> GetAsync();

        BuildingDTO Get(long id);

        void Delete(long id);

        void Add(Building newBuilding);

        void Update(Building Building);
    }
}
