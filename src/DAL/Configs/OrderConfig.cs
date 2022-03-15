using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ClientName).HasMaxLength(200).IsRequired();
            builder.Property(x => x.MedicamentName).HasMaxLength(100).IsRequired();
            builder.Property(x => x.PharmacyName).HasMaxLength(200).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();
        }
    }
}
