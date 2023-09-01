using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Elev8WebApp.Models
{
    public class MyDBContext : DbContext
    {
        //Install-Package Microsoft.EntityFrameworkCore.Tools
        //Add-Migration InitialCreate
        //Update-Database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(AppConfig.connString);
            }
        }
       
        
        // Define DbSet properties for your entities
        // For example:
        public DbSet<EmployeeInfo> EmployeeInfo { get; set; }
        public DbSet<EmployeeSalaryInfo> EmployeeSalaryInfo { get; set; }

    }
}
