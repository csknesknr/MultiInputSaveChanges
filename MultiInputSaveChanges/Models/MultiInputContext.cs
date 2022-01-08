using Microsoft.EntityFrameworkCore;

namespace MultiInputSaveChanges.Models
{
    public class MultiInputContext:DbContext
    {
        public DbSet<Egitim> Egitims { get; set; }
        public DbSet<Grup> Grups { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EgitimDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GrupMap());
            modelBuilder.ApplyConfiguration(new EgitimMap());
        }
    }
}
