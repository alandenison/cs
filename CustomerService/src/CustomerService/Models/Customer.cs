using System;
using System.Collections.Generic;

namespace CustomerService.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<CustomerLine> CustomerLines { get; set; }
    }
}