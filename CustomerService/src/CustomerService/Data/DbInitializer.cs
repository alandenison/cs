using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CustomerService.Data;

namespace CustomerService.Models
{
    public static class DbInitializer
    {
        public static void Initialize(CustomerServiceContext context)
        {
            context.Database.EnsureCreated();
            
            if (context.Customers.Any())
            {
                return;  
            }

            var customers = new Customer[]
            {
            new Customer { Name="Giggy Sanjan"},
            new Customer { Name="Alyssa Truelove"}
            };
            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();

            var lines = new Line[]
            {
            new Line {LineID=9000,Title="G-Mobile"},
            new Line {LineID=9001,Title="Laser Fry Cutter" }
            };
            foreach (Line l in lines)
            {
                context.Lines.Add(l);
            }
            context.SaveChanges();

            var customerLines = new CustomerLine[]
            {
            new CustomerLine{LineID=9000,CustomerID=1},
            new CustomerLine{LineID=9001,CustomerID=1},
            new CustomerLine{LineID=9000,CustomerID=2},

            };
            foreach (CustomerLine cl in customerLines)
            {
                context.CustomerLines.Add(cl);
            }
            context.SaveChanges();
        }
    }
}