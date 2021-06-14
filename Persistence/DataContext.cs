using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        //base(option) is parentClass constructor
        public DataContext(DbContextOptions options) : base(options) 
        {
        }
        //table into database and column will be depending on Activity Class
        public DbSet<Activity> Activities { get; set; }
    }
}