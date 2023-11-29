using Microsoft.AspNetCore.Mvc;
using VideoGameStore.Models;

namespace VideoGameStore.Controllers
{
    public class Games1Controller : Controller
    {
        //This is the Repository Class which implements IRepository ~/Models/DataLayer/Repositories/
        private Repository<Game> data { get; set; }
        //When the constructor is called

        //private readonly GameStoreContext _context;

        public Games1Controller(GameStoreContext _context)
        {
            data = new Repository<Game>(_context);
        }

        //for now we are going to have the /Index url redirect to the List method
        public RedirectToActionResult Index() => RedirectToAction("List");

        //We want to pass a GridData object to List View so that we can page through results
        public IActionResult List(GameGridData values)
        {
            /*
             * QueryOptions is our object for accesing and returning data sets
             * When the user clicks in the webpage the object is caught here 
             * and the data returned is updated accordingly
             */
            var options = new QueryOptions<Game>
            {
                Includes = "Genre, Publisher", // include genre and publisher in return data
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
            if (values.IsSortByGenre)
            {
                options.OrderBy = b => b.Genre.Name;
            }
            else if (values.IsSortByPublisher)
            {
                options.OrderBy = b => b.Publisher.Name;
            }
            else if (values.IsSortByPrice)
            {
                options.OrderBy = b => b.Price;
            }
            else
            {
                options.OrderBy = b => b.Title;
            }
            /*
             * Here the view model is constructed and instead of binding the Game model
             * to the List View we bind the game view model. If you look at List.cshtml
             * then you will see the directive at the top of the file @model GameListViewModel
             */
            var vm = new GameListViewModel
            {
                Games = data.List(options),
                CurrentRoute = values,
                TotalPages = values.GetTotalPages(data.Count)
            };
            //Once the values are set the view is returned with the appropriate view settings
            return View(vm);

        }
        //Code to link to the details page. 
        public ViewResult Details(int id)
        {
            var game = data.Get(new QueryOptions<Game>
            {
                Where = b => b.GameID == id,
                Includes = "Genre, Publisher"
            }) ?? new Game();

            return View(game);
        }
        
    }
}
