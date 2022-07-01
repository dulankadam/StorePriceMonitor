using Microsoft.EntityFrameworkCore;
using StorePriceMonitor.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorePriceMonitor.Infastructure.Persistance.Extensions.Seeds
{
    public static class PriceListSeed
    {
        public static void SeedPriceList(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PriceList>().HasData(
                new PriceList { Id = 1, Time = DateTime.Now.AddHours(1), Price = 110, PriceSourceId = 1, TickerListId = 1, Status = true },
                new PriceList { Id = 2, Time = DateTime.Now.AddHours(1.25), Price = 150, PriceSourceId = 1, TickerListId = 1, Status = true },
                new PriceList { Id = 3, Time = DateTime.Now.AddHours(1.5), Price = 140, PriceSourceId = 1, TickerListId = 1, Status = true },
                new PriceList { Id = 4, Time = DateTime.Now.AddHours(1.75), Price = 100, PriceSourceId = 1, TickerListId = 1, Status = true },
                new PriceList { Id = 5, Time = DateTime.Now.AddHours(2), Price = 140, PriceSourceId = 1, TickerListId = 1, Status = true },
                new PriceList { Id = 6, Time = DateTime.Now.AddHours(2.25), Price = 160, PriceSourceId = 1, TickerListId = 2, Status = true },
                new PriceList { Id = 7, Time = DateTime.Now.AddHours(2.5), Price = 130, PriceSourceId = 1, TickerListId = 2, Status = true },
                new PriceList { Id = 8, Time = DateTime.Now.AddHours(2.75), Price = 110, PriceSourceId = 1, TickerListId = 2, Status = true },
                new PriceList { Id = 9, Time = DateTime.Now.AddHours(3), Price = 200, PriceSourceId = 1, TickerListId = 2, Status = true },
                new PriceList { Id = 10, Time = DateTime.Now.AddHours(3.1), Price = 330, PriceSourceId = 1, TickerListId = 2, Status = true },
                new PriceList { Id = 11, Time = DateTime.Now.AddHours(3.2), Price = 210, PriceSourceId = 1, TickerListId = 2, Status = true },
                new PriceList { Id = 12, Time = DateTime.Now.AddHours(3.5), Price = 320, PriceSourceId = 1, TickerListId = 2, Status = true },
                new PriceList { Id = 13, Time = DateTime.Now.AddHours(3.8), Price = 340, PriceSourceId = 1, TickerListId = 3, Status = true },
                new PriceList { Id = 14, Time = DateTime.Now.AddHours(4), Price = 530, PriceSourceId = 1, TickerListId = 3, Status = true },
                new PriceList { Id = 15, Time = DateTime.Now.AddHours(4.1), Price = 760, PriceSourceId = 1, TickerListId = 3, Status = true },
                new PriceList { Id = 16, Time = DateTime.Now.AddHours(4.3), Price = 450, PriceSourceId = 1, TickerListId = 3, Status = true },
                new PriceList { Id = 17, Time = DateTime.Now.AddHours(1), Price = 860, PriceSourceId = 1, TickerListId = 3, Status = true },
                new PriceList { Id = 18, Time = DateTime.Now.AddHours(2), Price = 540, PriceSourceId = 1, TickerListId = 3, Status = true },
                new PriceList { Id = 19, Time = DateTime.Now.AddHours(4), Price = 220, PriceSourceId = 1, TickerListId = 4, Status = true },
                new PriceList { Id = 20, Time = DateTime.Now.AddHours(5), Price = 660, PriceSourceId = 1, TickerListId = 4, Status = true },
                new PriceList { Id = 21, Time = DateTime.Now.AddHours(3), Price = 750, PriceSourceId = 1, TickerListId = 4, Status = true },
                new PriceList { Id = 22, Time = DateTime.Now.AddHours(1), Price = 540, PriceSourceId = 1, TickerListId = 4, Status = true },
                new PriceList { Id = 23, Time = DateTime.Now.AddHours(5), Price = 320, PriceSourceId = 1, TickerListId = 4, Status = true },
                new PriceList { Id = 24, Time = DateTime.Now.AddHours(5), Price = 630, PriceSourceId = 1, TickerListId = 4, Status = true },
                new PriceList { Id = 25, Time = DateTime.Now.AddHours(3.5), Price = 530, PriceSourceId = 1, TickerListId = 4, Status = true },
                new PriceList { Id = 26, Time = DateTime.Now.AddHours(1), Price = 110, PriceSourceId = 2, TickerListId = 1, Status = true },
                new PriceList { Id = 27, Time = DateTime.Now.AddHours(1.25), Price = 150, PriceSourceId = 3, TickerListId = 1, Status = true },
                new PriceList { Id = 28, Time = DateTime.Now.AddHours(1.5), Price = 140, PriceSourceId = 5, TickerListId = 1, Status = true },
                new PriceList { Id = 29, Time = DateTime.Now.AddHours(1.75), Price = 100, PriceSourceId = 3, TickerListId = 1, Status = true },
                new PriceList { Id = 30, Time = DateTime.Now.AddHours(2), Price = 140, PriceSourceId = 2, TickerListId = 1, Status = true },
                new PriceList { Id = 31, Time = DateTime.Now.AddHours(2.25), Price = 160, PriceSourceId = 5, TickerListId = 2, Status = true },
                new PriceList { Id = 32, Time = DateTime.Now.AddHours(2.5), Price = 130, PriceSourceId = 5, TickerListId = 2, Status = true },
                new PriceList { Id = 33, Time = DateTime.Now.AddHours(2.75), Price = 110, PriceSourceId = 1, TickerListId = 2, Status = true },
                new PriceList { Id = 34, Time = DateTime.Now.AddHours(3), Price = 200, PriceSourceId = 5, TickerListId = 5, Status = true },
                new PriceList { Id = 35, Time = DateTime.Now.AddHours(3.1), Price = 330, PriceSourceId = 4, TickerListId = 4, Status = true },
                new PriceList { Id = 36, Time = DateTime.Now.AddHours(3.2), Price = 210, PriceSourceId = 4, TickerListId = 2, Status = true },
                new PriceList { Id = 37, Time = DateTime.Now.AddHours(3.5), Price = 320, PriceSourceId = 2, TickerListId = 3, Status = true },
                new PriceList { Id = 38, Time = DateTime.Now.AddHours(3.8), Price = 340, PriceSourceId = 1, TickerListId = 5, Status = true },
                new PriceList { Id = 39, Time = DateTime.Now.AddHours(4), Price = 530, PriceSourceId = 1, TickerListId = 2, Status = true },
                new PriceList { Id = 40, Time = DateTime.Now.AddHours(4.1), Price = 760, PriceSourceId = 2, TickerListId = 2, Status = true },
                new PriceList { Id = 41, Time = DateTime.Now.AddHours(4.3), Price = 450, PriceSourceId = 3, TickerListId = 3, Status = true },
                new PriceList { Id = 42, Time = DateTime.Now.AddHours(1), Price = 860, PriceSourceId = 3, TickerListId = 3, Status = true },
                new PriceList { Id = 43, Time = DateTime.Now.AddHours(2), Price = 540, PriceSourceId = 4, TickerListId = 3, Status = true },
                new PriceList { Id = 44, Time = DateTime.Now.AddHours(4), Price = 220, PriceSourceId = 4, TickerListId = 4, Status = true },
                new PriceList { Id = 45, Time = DateTime.Now.AddHours(5), Price = 660, PriceSourceId = 5, TickerListId = 4, Status = true },
                new PriceList { Id = 46, Time = DateTime.Now.AddHours(3), Price = 750, PriceSourceId = 5, TickerListId = 4, Status = true },
                new PriceList { Id = 47, Time = DateTime.Now.AddHours(1), Price = 540, PriceSourceId = 3, TickerListId = 3, Status = true },
                new PriceList { Id = 48, Time = DateTime.Now.AddHours(5), Price = 320, PriceSourceId = 2, TickerListId = 4, Status = true },
                new PriceList { Id = 49, Time = DateTime.Now.AddHours(5), Price = 630, PriceSourceId = 2, TickerListId = 4, Status = true }
                );
        }
    }
}
