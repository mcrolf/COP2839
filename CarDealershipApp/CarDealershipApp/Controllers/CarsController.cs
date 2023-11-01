using Microsoft.AspNetCore.Mvc;
using CarDealershipApp.Models;


namespace CarDealershipApp.Controllers
{
    public class CarsController : Controller
    {
        private Repository<Car> data {  get; set; }

        public CarsController(CarDealerContext _context)
        {
            data = new Repository<Car>(_context);
        }

        //for now we are going to have the /Index url redirect to the List method
        public RedirectToActionResult Index() => RedirectToAction("List");

        //We want to pass a GridData object to List View so that we can page through results
        public IActionResult List(CarGridData values)
        {
            /*
             * QueryOptions is our object for accesing and returning data sets
             * When the user clicks in the webpage the object is caught here 
             * and the data returned is updated accordingly
             */
            var options = new QueryOptions<Car>
            {
                //Includes = "Manufacturer, CarModel", // include Make and Model in return data
                OrderByDirection = values.SortDirection, //captured when user clicks in the web page
                PageNumber = values.PageNumber, //
                PageSize = values.PageSize,
            };
            /*
             * These flags are set by the user clicking in the webpage by code that looks like this
             * Here this toggles the Genre field. If the direction is asc then it is set to desc creating a toggle
               @{
                    routes.SetSortAndDirection(
                    nameof(Game.Genre), current);
                }
                <a asp-action="List"
                   asp-all-route-data="@routes.ToDictionary()"
                   class="text-white">Genre</a>
            */
            if (values.IsSortByManufacturer)
            {
                options.OrderBy = b => b.Manufacturer.Name;
            }
            else if (values.IsSortByModel)
            {
                options.OrderBy = b => b.CarModel;
            }
            else if (values.IsSortByPrice)
            {
                options.OrderBy = b => b.StickerPrice;
            }
            else
            {
                options.OrderBy = b => b.Year;
            }
            /*
             * Here the view model is constructed and instead of binding the Car model
             * to the List View we bind the car view model. If you look at List.cshtml
             * then you will see the directive at the top of the file @model CarListViewModel
             */
            var vm = new CarListViewModel
            {
                Cars = data.List(options),
                CurrentRoute = values,
                TotalPages = values.GetTotalPages(data.Count)
            };
            //Once the values are set the view is returned with the appropriate view settings
            return View(vm);

        }
        //Code to link to the details page. 
        public ViewResult Details(int id)
        {
            var car = data.Get(new QueryOptions<Car>
            {
                Where = b => b.CarID == id,
                Includes = "Manufacturer, CarModel"
            }) ?? new Car();

            return View(car);
        }

       
    }
}
