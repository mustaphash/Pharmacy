// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(PharmacyContext))]
    [Migration("20220208223427_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClientMedicament", b =>
                {
                    b.Property<int>("ClientIdId")
                        .HasColumnType("int");

                    b.Property<int>("MedicamentIdId")
                        .HasColumnType("int");

                    b.HasKey("ClientIdId", "MedicamentIdId");

                    b.HasIndex("MedicamentIdId");

                    b.ToTable("ClientMedicament");
                });

            modelBuilder.Entity("ClientPharmacy", b =>
                {
                    b.Property<int>("ClientIdId")
                        .HasColumnType("int");

                    b.Property<int>("PharmacyIdId")
                        .HasColumnType("int");

                    b.HasKey("ClientIdId", "PharmacyIdId");

                    b.HasIndex("PharmacyIdId");

                    b.ToTable("ClientPharmacy");
                });

            modelBuilder.Entity("Core.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Points")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Core.Entities.Medicament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Medicaments");
                });

            modelBuilder.Entity("Core.Entities.Pharmacy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pharmacies");
                });

            modelBuilder.Entity("MedicamentPharmacy", b =>
                {
                    b.Property<int>("MedicamentIdId")
                        .HasColumnType("int");

                    b.Property<int>("PharmacyIdId")
                        .HasColumnType("int");

                    b.HasKey("MedicamentIdId", "PharmacyIdId");

                    b.HasIndex("PharmacyIdId");

                    b.ToTable("MedicamentPharmacy");
                });

            modelBuilder.Entity("ClientMedicament", b =>
                {
                    b.HasOne("Core.Entities.Client", null)
                        .WithMany()
                        .HasForeignKey("ClientIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Medicament", null)
                        .WithMany()
                        .HasForeignKey("MedicamentIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClientPharmacy", b =>
                {
                    b.HasOne("Core.Entities.Client", null)
                        .WithMany()
                        .HasForeignKey("ClientIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Pharmacy", null)
                        .WithMany()
                        .HasForeignKey("PharmacyIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MedicamentPharmacy", b =>
                {
                    b.HasOne("Core.Entities.Medicament", null)
                        .WithMany()
                        .HasForeignKey("MedicamentIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Pharmacy", null)
                        .WithMany()
                        .HasForeignKey("PharmacyIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
