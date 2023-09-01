using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Elev8WebApp.Models
{
    public class MyDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(AppConfig.connString);
            }
        }
        /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             if (!optionsBuilder.IsConfigured)
             {
                 var configuration = new ConfigurationBuilder()
                     .SetBasePath(Directory.GetCurrentDirectory())
                     .AddJsonFile("appsettings.json")
                     .AddJsonFile("appsettings.Development.json", optional: true)
                     .Build();

                 optionsBuilder.UseSqlServer(configuration.GetConnectionString("myConnString"));
             }
         }*/
        // Define DbSet properties for your entities
        // For example:
        public DbSet<EmployeeInfo> EmployeeInfo { get; set; }

    }
}
