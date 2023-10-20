namespace CarDealershipApp.Models
{
    public class Customer
    {
        //******************************************
        // define attributed for customer
        //******************************************
        public int CustomerID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int PhoneNumber { get; set; }
    }
}
