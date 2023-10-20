namespace CarDealershipApp.Models
{
    public class Car
    {

        public int CarID { get; set; }
        public int ManufacturerID { get; set; }
        public string? Model {  get; set; }
        public int Year { get; set; }
        public decimal StickerPrice { get; set; }
        public string? VIN { get; set; }
        public int Mileage { get; set; }
        public string? Color { get; set; }

    }
}
