using System.Reflection;
using DMS.Models;
using Microsoft.EntityFrameworkCore;


namespace DMS
{
    public class DoctorDbContext : DbContext
    {
        public DbSet<Doctor>? Doctors { get; set; }

        public DoctorDbContext(DbContextOptions<DoctorDbContext> options)
            : base(options) // Pass the options to the base DbContext constructor
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=DMS;Username=postgres;Password=postgres;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

    }
}
