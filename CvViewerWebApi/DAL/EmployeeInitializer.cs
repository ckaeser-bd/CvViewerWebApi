using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CvViewerWebApi.Models;

namespace CvViewerWebApi.DAL
{
    public class EmployeeInitializer : DropCreateDatabaseIfModelChanges<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            //var employees = new List<Employee>
            //{
            //    new Employee {FirstName = "Christian", LastName = "Käser"},
            //    new Employee {FirstName = "Daniel", LastName = "Handschin"},
            //    new Employee {FirstName = "Susen", LastName = "Walther"},
            //    new Employee {FirstName = "Patrick", LastName = "Götschi"},
            //    new Employee {FirstName = "Markus", LastName = "Brügger"},
            //    new Employee {FirstName = "Jörg", LastName = "Heymoz"},
            //    new Employee {FirstName = "Urs", LastName = "Kloter"},
            //};

            //employees.ForEach(e => context.Employees.Add(e));
            //context.SaveChanges();

        }
    }
}