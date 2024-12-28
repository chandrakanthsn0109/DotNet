using System.Reflection;
using BMSApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BMSApi
{
    public class BillDbContext : DbContext
    {
        public BillDbContext(DbContextOptions<BillDbContext> options) : base(options)
        {

        }

        public DbSet<Bill> Bills { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Bill;Username=postgres;Password=postgres;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
