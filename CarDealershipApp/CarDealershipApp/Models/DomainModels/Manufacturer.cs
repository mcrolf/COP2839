namespace CarDealershipApp.Models
{
    public class Manufacturer
    {
        //******************************************
        // manufacturers is a hash set of manufacturer objects
        //******************************************
        public Manufacturer() => Manufacturers = new HashSet<Manufacturer>();

        //******************************************
        // define attributes for manufacturer
        //******************************************
        public int ManufacturerID { get; set; }
        public string? Name { get; set; }
        public string? WebURL { get; set; }

        public ICollection<Manufacturer> Manufacturers { get; set; }
    }
}
