using Microsoft.EntityFrameworkCore;
using Parcial.Shared.Entities;

namespace Parcial.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {         

        }
        
        public DbSet<Entrance> Entrances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Entrance>().HasIndex(x => x.Id).IsUnique();

        }

    }
}
