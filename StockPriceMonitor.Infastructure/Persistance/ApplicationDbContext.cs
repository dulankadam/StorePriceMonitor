using Microsoft.EntityFrameworkCore;
using StorePriceMonitor.Core.Common.Interfaces;
using StorePriceMonitor.Domain.Models;
using StorePriceMonitor.Infastructure.Persistance.Extensions.Seeds;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StorePriceMonitor.Infastructure.Persistance
{
    public partial class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        private readonly ICurrentUserService _currentUserService;
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            string user = GetUser();

            foreach (var entry in ChangeTracker.Entries<ModelBase>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        if (String.IsNullOrWhiteSpace(entry.Entity.CreatedUser))
                        {
                            entry.Entity.CreatedUser = user;
                        }
                        break;
                    case EntityState.Modified:
                        entry.Entity.UpdatedDate = DateTime.Now;
                        if (String.IsNullOrWhiteSpace(entry.Entity.UpdatedUser))
                        {
                            entry.Entity.UpdatedUser = user;
                        }
                        break;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);

        }

        private string GetUser()
        {
            string user;
            user = "Annonymous User";
            return user;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.SeedPriceSource();
            modelBuilder.SeedTickerList();
            modelBuilder.SeedPriceList();

        }

        #region Master Data Tables
        public virtual DbSet<PriceSource> PriceSources { get; set; }
        public virtual DbSet<TickerList> TickerLists { get; set; }

        #endregion

        #region Operational Data Tables
        public virtual DbSet<PriceList> PriceLists { get; set; }
        #endregion

    }
}
