using System;
using System.Collections.Generic;
using System.Text;
using Homework2.Models.DTO;

namespace Homework2.Services.Interfaces
{
    /// <summary>
    /// Интерфейс для сервиса "Здание"
    /// </summary>
   public interface IBuildingService
    {
        IEnumerable<BuildingDTO> GetAsync();
    }
}
