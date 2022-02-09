using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class PharmacyContext : DbContext
    {
        public PharmacyContext()
        {
        }
        public PharmacyContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Pharmacy> Pharmacies { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MUSTAFA;Initial Catalog=Pharmacy;Integrated Security=True;Pooling=False");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
