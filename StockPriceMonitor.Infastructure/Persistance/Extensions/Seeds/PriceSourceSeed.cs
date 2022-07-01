using Microsoft.EntityFrameworkCore;
using StorePriceMonitor.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorePriceMonitor.Infastructure.Persistance.Extensions.Seeds
{
    public static class PriceSourceSeed
    {
        public static void SeedPriceSource(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PriceSource>().HasData(
                new PriceSource { Id = 1, Description = "PRC 1", CreatedDate = DateTime.Now, CreatedUser = "System Seed" },
                new PriceSource { Id = 2, Description = "PRC 2", CreatedDate = DateTime.Now, CreatedUser = "System Seed" },
                new PriceSource { Id = 3, Description = "PRC 3", CreatedDate = DateTime.Now, CreatedUser = "System Seed" },
                new PriceSource { Id = 4, Description = "PRC 4", CreatedDate = DateTime.Now, CreatedUser = "System Seed" },
                new PriceSource { Id = 5, Description = "PRC 5", CreatedDate = DateTime.Now, CreatedUser = "System Seed" }
                );
        }
    }
}
