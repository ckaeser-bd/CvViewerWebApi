using System.Collections.Generic;

namespace CvViewerWebApi.Migrations
{
    using Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.EmployeeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.EmployeeContext context)
        {
            var employees = new List<Employee>
            {
                new Employee {FirstName = "Christian", LastName = "Käser"},
                new Employee {FirstName = "Daniel", LastName = "Handschin"},
                new Employee {FirstName = "Michael ", LastName = "Seifried"},
                new Employee {FirstName = "Jörg", LastName = "Heimoz"},
            };

            employees.ForEach(e => context.Employees.Add(e));
            context.SaveChanges();
        }
    }
}
