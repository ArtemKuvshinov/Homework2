using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Homework2.Services.Interfaces;
using Homework2.Services.Services;

namespace Homework2.Services.Bootstrap
{
  public static class ServicesConfiguration
    {
        /// <summary>
        /// Конфигурация сервисов.
        /// Это метод расширения из класса Startup
        /// </summary>
        /// <param name="services">Коллекция сервисов из Startup.</param>
        public static void ConfigureServices(this IServiceCollection services)
        {
            // Выбор конкретной реализации для IBuildingService. В данном случае это BuildingService.
            services.AddTransient<IBuildingService, BuildingService>();
        }
    }
}
