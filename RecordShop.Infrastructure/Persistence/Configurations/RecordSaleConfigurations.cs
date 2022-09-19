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
    public class RecordSaleConfigurations : IEntityTypeConfiguration<RecordSale>
    {
        public void Configure(EntityTypeBuilder<RecordSale> builder)
        {
            
            builder.HasKey(x => x.Id);
        }
    }
}
