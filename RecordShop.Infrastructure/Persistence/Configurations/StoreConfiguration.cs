using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecordShop.Core.Entities;

namespace RecordShop.Infrastructure.Persistence.Configurations
{
    public class StoreConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder
                .HasKey(x => x.Id);
        }
    }
}
