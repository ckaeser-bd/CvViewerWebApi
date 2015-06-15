using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using CvViewerWebApi.Models;

namespace CvViewerWebApi.DAL
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("EmployeeContext")
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}