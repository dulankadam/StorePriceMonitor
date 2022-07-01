using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StorePriceMonitor.Infastructure.Persistance;
using StorePriceMonitor.Core.Common.Interfaces;

namespace StorePriceMonitor.Infastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(
                    configuration.GetConnectionString("Default")
                );
                options.EnableSensitiveDataLogging(true);
            });

            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());
            return services;
        }
    }
}
