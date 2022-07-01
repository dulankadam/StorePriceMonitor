using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StorePriceMonitor.Domain.Models;

namespace StorePriceMonitor.Core.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        DbSet<TModel> Set<TModel>() where TModel : class;

        #region Master Data Tables
        public DbSet<PriceSource> PriceSources { get; set; }
        public DbSet<TickerList> TickerLists { get; set; }

        #endregion

        #region Operational Data Tables
        public DbSet<PriceList> PriceLists { get; set; }
        #endregion
    }
}
