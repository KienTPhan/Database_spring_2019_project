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
        // public DbSet<Death> Deaths { get; set; }
    }
}