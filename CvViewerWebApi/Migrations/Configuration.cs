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
                new Employee {FirstName = "Susen", LastName = "Walther"},
                new Employee {FirstName = "Patrick", LastName = "Götschi"},
                new Employee {FirstName = "Markus", LastName = "Brügger"},
                new Employee {FirstName = "Jörg", LastName = "Heymoz"},
                new Employee {FirstName = "Urs", LastName = "Kloter"},
            };

            employees.ForEach(e => context.Employees.Add(e));
            context.SaveChanges();
        }
    }
}
