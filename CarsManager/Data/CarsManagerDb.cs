using System.IO;
using System.Reflection;
using Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class CarsManagerDb : DbContext
    {
        public virtual DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                $"Data Source={Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}/db.sqlite");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}