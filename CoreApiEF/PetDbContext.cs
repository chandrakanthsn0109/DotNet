using System.Reflection;
using CoreApiEF.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreApiEF
{
    public class PetDbContext : DbContext
    {
        public PetDbContext(DbContextOptions<PetDbContext> options) : base(options)
        {

        }
        public DbSet<PetAnimal>? PetAnimals { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=PetAnimal;Username=postgres;Password=postgres;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
