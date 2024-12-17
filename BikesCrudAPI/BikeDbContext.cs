using BikesCrudAPI.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BikesCrudAPI
{
    public class BikeDbContext:DbContext
    {

        public DbSet<Bike>? Bikes { get; set; }

        public BikeDbContext(DbContextOptions<BikeDbContext> options)
            : base(options) 
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Bike;Username=postgres;Password=postgres;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    
    }
}
