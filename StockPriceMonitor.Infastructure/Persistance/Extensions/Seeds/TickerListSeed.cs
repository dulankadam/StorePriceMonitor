using Microsoft.EntityFrameworkCore;
using StorePriceMonitor.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorePriceMonitor.Infastructure.Persistance.Extensions.Seeds
{
    public static class TickerListSeed
    {
        public static void SeedTickerList(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TickerList>().HasData(
               new TickerList { Id = 1, Description = "TICKER 1", CreatedDate = DateTime.Now, CreatedUser = "System Seed" },
               new TickerList { Id = 2, Description = "TICKER 2", CreatedDate = DateTime.Now, CreatedUser = "System Seed" },
               new TickerList { Id = 3, Description = "TICKER 3", CreatedDate = DateTime.Now, CreatedUser = "System Seed" },
               new TickerList { Id = 4, Description = "TICKER 4", CreatedDate = DateTime.Now, CreatedUser = "System Seed" },
               new TickerList { Id = 5, Description = "TICKER 5", CreatedDate = DateTime.Now, CreatedUser = "System Seed" }
               );
        }
    }
}
