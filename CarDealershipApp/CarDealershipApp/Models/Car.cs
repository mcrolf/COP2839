namespace CarDealershipApp.Models
{
    //******************************************
    // enum for colors
    //******************************************
    public enum Color
    {
        Red,
        Black,
        White,
        Silver,
        Blue,
        Tan,
        Gold,
        Other
    }
    public class Car
    {
        //******************************************
        // define attributes for car
        //******************************************
        public int CarID { get; set; }
        public Color Color { get; set; }
        public int ManufacturerID { get; set; }
        public Manufacturer Manufacturer { get; set; } = null!; // foreign key
        public int Mileage { get; set; }
        public string? Model {  get; set; }
        public decimal StickerPrice { get; set; }
        public string? VIN { get; set; }
        public int Year { get; set; }


    }
}
