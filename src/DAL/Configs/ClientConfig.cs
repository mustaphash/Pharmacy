using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class ClientConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.Property(x => x.Id).IsRequired();

            builder.HasKey(x => x.FirstName);
            builder.Property(x => x.LastName).HasMaxLength(200).IsRequired();
            builder.Property(x => x.BirthDate).IsRequired();
            builder.Property(x => x.Points).IsRequired();
        }
    }
}
