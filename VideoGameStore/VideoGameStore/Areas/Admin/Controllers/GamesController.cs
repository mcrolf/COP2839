using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VideoGameStore.Areas.Admin.Models;
using VideoGameStore.Models;

namespace VideoGameStore.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]

    public class GamesController : Controller
    {
        private Repository<Game> gameData;
        private Repository<Genre> genreData;
        private Repository<Publisher> publisherData;

        public GamesController(GameStoreContext context)
        {
            gameData = new Repository<Game>(context);
            genreData = new Repository<Genre>(context);
            publisherData = new Repository<Publisher>(context);
        }

        // GET: Admin/Games
        public IActionResult Index()
        {

            var games = gameData.List(new QueryOptions<Game>
            {
                Includes = "Genre, Publisher",
                OrderBy = g => g.Title

            });
            return View(games);
        }

        // GET: Admin/Games/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null || gameData == null)
            {
                return NotFound();
            }

            var game = gameData.Get(new QueryOptions<Game>
            {
                Includes = "Genre, Publisher"
            });

            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // GET: Admin/Games/Create
        [HttpGet]
        public IActionResult Create()
        {

            var vm = new GameViewModel();
            LoadViewData(vm);
            return View("Create", vm);
        }

        // POST: Admin/Games/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(GameViewModel vm)
        {
            if (ModelState.IsValid)
            {
                gameData.Insert(vm.game);
                gameData.Save();
                TempData["message"] = $"{vm.game.Title} added to the Games List";
                return RedirectToAction("Index");
            }
            else
            {
                LoadViewData(vm);
                return View("Create");

            }
        }

        // GET: Admin/Games/Edit/5
        public IActionResult Edit(int id)
        {
            var vm = new GameViewModel
            {
                game = GetGame(id)
            };

            if (vm.game == null)
            {
                return NotFound();
            }
            LoadViewData(vm);

            return View("Edit", vm);
        }

        // POST: Admin/Games/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(GameViewModel vm)
        {
            if (vm.game == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    gameData.Update(vm.game);
                    gameData.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameExists(vm.game.GameID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                TempData["message"] = $"{vm.game.Title} edited";
                return RedirectToAction(nameof(Edit));
            }
            return View("Edit", vm.game.GameID);
        }

        // GET: Admin/Games/Delete/5
        [HttpGet]
        public IActionResult Delete(int id)
        {

            var vm = new GameViewModel
            {
                game = GetGame(id)
            };

            if (vm.game == null)
            {
                return NotFound();
            }

            return View("Delete", vm.game);
        }

        // POST: Admin/Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Game game)
        {
            if (gameData == null)
            {
                return Problem("Entity set 'Repository<Game> gameData'  is null.");
            }
            var gameToDelete = gameData.Get(game.GameID);
            if (gameToDelete != null)
            {
                gameData.Delete(gameToDelete);
                gameData.Save();
                TempData["message"] = $"{gameToDelete.Title} removed from inventory";
            }

            return RedirectToAction(nameof(Delete));
        }

        private void LoadViewData(GameViewModel vm)
        {
            vm.genres = genreData.List(new QueryOptions<Genre> { OrderBy = g => g.Name });
            vm.publishers = publisherData.List(new QueryOptions<Publisher> { OrderBy = p => p.Name });
        }

        private Game GetGame(int id)
        {
            return gameData.Get(new QueryOptions<Game>
            {
                Where = b => b.GameID == id,
                Includes = "Genre, Publisher"
            }) ?? new Game();
        }

        private bool GameExists(int id)
        {
            if (gameData.Get(id) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
