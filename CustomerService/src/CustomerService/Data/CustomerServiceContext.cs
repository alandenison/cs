using CustomerService.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerService.Data
{
    public class CustomerServiceContext : DbContext
    {
        public CustomerServiceContext(DbContextOptions<CustomerServiceContext> options) : base(options)
        {
        }

        public DbSet<Line> Lines { get; set; }
        public DbSet<CustomerLine> CustomerLines { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}