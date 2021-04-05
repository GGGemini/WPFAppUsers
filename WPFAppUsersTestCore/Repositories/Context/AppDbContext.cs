using Microsoft.EntityFrameworkCore;
using System.IO;
using WPFAppUsersTestCore.Models.Entities;

namespace WPFAppUsersTestCore.Repositories.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Subdivision> Subdivisions { get; set; }
        public DbSet<Order> Orders { get; set; }

        // Package manager console commands
        // Add-Migration “Initial-Commit”
        // Update-Database

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;

            string appName = "WPFAppUsersTest";

            int index = path.IndexOf(appName);
            path = path.Remove(index);
            path = $"{path}{appName}/WPFAppUsersTestCore/Repositories/Context/WpfDB.db";
            optionsBuilder.UseSqlite($"Data Source={path}");
        }
    }
}
