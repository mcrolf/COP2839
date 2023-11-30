using CarDealershipApp.Models;

namespace CarDealershipApp.Areas.Admin.Models
{
    public class CarViewModel
    {
        public Car car {  get; set; } = new Car();

        //---------------------------------------------------
        // list of manufacturers
        //---------------------------------------------------
        public IEnumerable<Manufacturer> manufacturers { get; set; } = new List<Manufacturer>();

        //---------------------------------------------------
        // list of colors
        //---------------------------------------------------
        public IEnumerable<Color> colors { get; set; } = new List<Color>();
    }
}
