using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecordShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordShop.Infrastructure.Persistence.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
                .HasKey(o => o.Id);

            builder
                .HasMany(o => o.Records)
                .WithOne()
                .HasForeignKey(o => o.IdOrder)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.IdClient)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(o => o.Store)
                .WithMany(s => s.Sales)
                .HasForeignKey(o => o.IdStore)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
