
using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using VideoGameStore.DAL;
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
            //_context = context;
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
        //Previously generated methods commented out continues...

        // GET: Games1
        /*public async Task<IActionResult> Index()
        {
            var gameStoreContext = _context.Games.Include(g => g.Genre).Include(g => g.Publisher);
            return View(await gameStoreContext.ToListAsync());
        }*/

        // GET: Games1/Details/5
       /* public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Games == null)
            {
                return NotFound();
            }

            var game = await _context.Games
                .Include(g => g.Genre)
                .Include(g => g.Publisher)
                .FirstOrDefaultAsync(m => m.GameID == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }*/

        // GET: Games1/Create
        /*public IActionResult Create()
        {
            ViewData["GenreID"] = new SelectList(_context.Genres, "GenreID", "GenreID");
            ViewData["GenreID"] = new SelectList(_context.Publishers, "GenreID", "GenreID");
            return View();
        }*/

        // POST: Games1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GameID,Title,ReleaseDate,PLatform,Price,StockQuantity,GenreID,GenreID")] Game game)
        {
            if (ModelState.IsValid)
            {
                _context.Add(game);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GenreID"] = new SelectList(_context.Genres, "GenreID", "GenreID", game.GenreID);
            ViewData["GenreID"] = new SelectList(_context.Publishers, "GenreID", "GenreID", game.GenreID);
            return View(game);
        }*/

        // GET: Games1/Edit/5
       /* public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Games == null)
            {
                return NotFound();
            }

            var game = await _context.Games.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }
            ViewData["GenreID"] = new SelectList(_context.Genres, "GenreID", "GenreID", game.GenreID);
            ViewData["GenreID"] = new SelectList(_context.Publishers, "GenreID", "GenreID", game.GenreID);
            return View(game);
        }*/

        // POST: Games1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
       /* [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GameID,Title,ReleaseDate,PLatform,Price,StockQuantity,GenreID,GenreID")] Game game)
        {
            if (id != game.GameID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(game);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameExists(game.GameID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["GenreID"] = new SelectList(_context.Genres, "GenreID", "GenreID", game.GenreID);
            ViewData["GenreID"] = new SelectList(_context.Publishers, "GenreID", "GenreID", game.GenreID);
            return View(game);
        }*/

        // GET: Games1/Delete/5
        /*public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Games == null)
            {
                return NotFound();
            }

            var game = await _context.Games
                .Include(g => g.Genre)
                .Include(g => g.Publisher)
                .FirstOrDefaultAsync(m => m.GameID == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }*/

        // POST: Games1/Delete/5
        /*[HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Games == null)
            {
                return Problem("Entity set 'GameStoreContext.Games'  is null.");
            }
            var game = await _context.Games.FindAsync(id);
            if (game != null)
            {
                _context.Games.Remove(game);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }*/

        /*private bool GameExists(int id)
        {
          return (_context.Games?.Any(e => e.GameID == id)).GetValueOrDefault();
        }*/
    }
}
