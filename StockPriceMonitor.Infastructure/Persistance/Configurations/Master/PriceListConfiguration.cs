using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StorePriceMonitor.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorePriceMonitor.Infastructure.Persistance.Configurations.Master
{
    public class PriceListConfiguration : IEntityTypeConfiguration<PriceList>
    {
        public void Configure(EntityTypeBuilder<PriceList> builder)
        {
            builder.ToTable("PriceList","pr");
            builder.HasKey(p=>p.Id);
            builder.Property(p=>p.Id).UseIdentityColumn();
            builder.Property(p => p.Time).IsRequired();
            builder.Property(p=> p.PriceSourceId).IsRequired();
        }
    }
}
