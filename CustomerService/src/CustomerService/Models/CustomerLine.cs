namespace CustomerService.Models
{
    public class CustomerLine
    {
        public int CustomerLineID { get; set; }
        public int LineID { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
    }
}