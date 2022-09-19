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
    public class RecordConfigurations : IEntityTypeConfiguration<Record>
    {
        public void Configure(EntityTypeBuilder<Record> builder)
        {
            builder
                .HasKey(r => r.Id);

            builder
               .HasOne(r => r.Store)
               .WithMany(s => s.Records)
               .HasForeignKey(r => r.IdStore)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
