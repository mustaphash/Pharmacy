﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class MedicamentConfig : IEntityTypeConfiguration<Medicament>
    {
        public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            builder.HasKey(x => x.Name);

            builder.Property(x => x.Id);
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.ExpirationDate).IsRequired();
        }
    }
}
