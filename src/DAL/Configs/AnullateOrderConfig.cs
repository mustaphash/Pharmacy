using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class AnullateOrderConfig : IEntityTypeConfiguration<AnullatedOrder>
    {
        public void Configure(EntityTypeBuilder<AnullatedOrder> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ClientId).IsRequired();
            builder.Property(x => x.MedicamentId).IsRequired();
            builder.Property(x => x.PharmacyId).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();
        }
    }
}
