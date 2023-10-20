namespace CarDealershipApp.Models
{
    public class Employee
    {
        //******************************************
        // define attributes for employee
        //******************************************
        public int EmployeeID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Position { get; set; }
        public string? ContactInfo { get; set; }
        public decimal Salary { get; set; }
    }
}
