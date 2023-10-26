namespace CarDealershipApp.Models
{
    public class Sale
    {
        //******************************************
        // define sale attributes
        //******************************************
        public int SaleID { get; set; }
        public DateTime SaleDate {  get; set; }
        public decimal TotalAmount { get; set; }
        public string? PaymentMethod { get; set; }
        public int CustomerID { get; set; }
        public int CarID { get; set; }
        public int EmployeeID { get; set; }

    }
}
