namespace CarDealershipApp.Models
{
    public class CarListViewModel
    {
        public IEnumerable<Car> Cars { get; set; } = new List<Car>();
        public CarGridData CurrentRoute { get; set; } = new CarGridData();
        public int TotalPages { get; set; }
    }
}
