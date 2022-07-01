using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StorePriceMonitor.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorePriceMonitor.Infastructure.Persistance.Configurations.Prices
{
    public class PriceSourceConfiguration : IEntityTypeConfiguration<PriceSource>
    {
        public void Configure(EntityTypeBuilder<PriceSource> builder)
        {
            builder.ToTable("PriceSource", "msr");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.Description).IsRequired();
        }
    }
}
