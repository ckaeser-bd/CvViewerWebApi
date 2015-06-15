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


/*
Fiddler:
-----------------------------------------------------------
Post http://employeewebapi.azurewebsites.net/api/employee/
-----------------------------------------------------------
User-Agent: Fiddler
Host: employeewebapi.azurewebsites.net
Content-Type: application/json
Content-Length: 45
----------------------------------------------------------
{"LastName":"Käser","FirstName":"Christian"}
{"LastName":"Handschin","FirstName":"Daniel"}
{"LastName":"AAAAA","FirstName":"BBBBB"}
{"LastName":"AAAAA","FirstName":"CCCCC"} 
{"LastName":"AAAAA","FirstName":"BCBCB"}

*/