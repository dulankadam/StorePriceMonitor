using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StorePriceMonitor.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorePriceMonitor.Infastructure.Persistance.Configurations.Master
{
    public class TickerListConfiguration : IEntityTypeConfiguration<TickerList>
    {
        public void Configure(EntityTypeBuilder<TickerList> builder)
        {
            builder.ToTable("TickerList", "msr");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).UseIdentityColumn();
            builder.Property(t => t.Description).IsRequired();
        }
    }
}
