namespace CarDealershipApp.Models
{
    public class Inventory
    {
        //******************************************
        // inventory has a new hash set containing car objects
        //******************************************
        public Inventory() => Cars = new HashSet<Car>();

        //******************************************
        // define attributes for inventory
        //******************************************
        public int InventoryID { get; set; }
        public int InStockQuantity { get; set; }
        public int CarID { get; set; }
        public int LotID { get; set; }

        //******************************************
        // Cars is a collection of car objects
        //******************************************
        public ICollection<Car> Cars { get; set; }

    }
}
