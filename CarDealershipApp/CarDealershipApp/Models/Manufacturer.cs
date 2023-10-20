namespace CarDealershipApp.Models
{
    public class Manufacturer
    {
        public Manufacturer() => Cars = new HashSet<Car>();

        public int ManufacturerID { get; set; }
        public string? Name { get; set; }
        public string? WebURL { get; set; }

        public ICollection<Car> Cars {  get; set; }
    }
}
