using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerService.Models
{
    public class Line
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LineID { get; set; }
        public string Title { get; set; }

        public ICollection<CustomerLine> CustomerLine { get; set; }
    }
}