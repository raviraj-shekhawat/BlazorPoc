using Microsoft.EntityFrameworkCore;
using WebAPI.Data.Entities;

namespace WebAPI.Data
{
    public class BlzrDbContext : DbContext
    {
        public BlzrDbContext(DbContextOptions<BlzrDbContext> options):base(options) 
        {
                
        }
        public DbSet<SuperHeroes> SuperHeroes { get; set; }
    }
}
