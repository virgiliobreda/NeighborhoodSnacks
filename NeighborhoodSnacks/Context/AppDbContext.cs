using Microsoft.EntityFrameworkCore;
using NeighborhoodSnacks.Models;

namespace NeighborhoodSnacks.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base(options) 
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Snacks> Snacks { get; set; }
    }
}
