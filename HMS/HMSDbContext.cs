using System.Reflection;
using HMS.Models;
using Microsoft.EntityFrameworkCore;

namespace HMS
{
    public class HMSDbContext : DbContext
    {
        public DbSet<Doctor>? Doctor { get; set; }

        public DbSet<Hospital>? Hospital { get; set; }

        public DbSet<Patient> Patient { get; set; }


        public HMSDbContext(DbContextOptions<HMSDbContext> options)
            : base(options) // Pass the options to the base DbContext constructor
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=HMS;Username=postgres;Password=postgres;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

    }
}
