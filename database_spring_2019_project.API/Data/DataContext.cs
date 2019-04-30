
using Microsoft.EntityFrameworkCore;
using USVisual.API.Models;

namespace USVisual.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {
            
        }

         public DbSet<Value> Values { get; set;}
         public DbSet<Death> Deaths { get; set; }
         public DbSet<Deaths> Events { get; set; }
         public DbSet<Country> Countrys {get;set;}
        // public DbSet<Death> Deaths { get; set; }
    }
}