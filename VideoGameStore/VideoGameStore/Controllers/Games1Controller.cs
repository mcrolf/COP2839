using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VideoGameStore.DAL;
using VideoGameStore.Models;

namespace VideoGameStore.Controllers
{
    public class Games1Controller : Controller
    {
        private readonly GameStoreContext _context;

        public Games1Controller(GameStoreContext context)
        {
            _context = context;
        }

        // GET: Games1
        public async Task<IActionResult> Index()
        {
            var gameStoreContext = _context.Games.Include(g => g.Genre).Include(g => g.Publisher);
            return View(await gameStoreContext.ToListAsync());
        }

        // GET: Games1/Details/5
        public async Task<IActionResult> Details(int? id)
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
        }

        // GET: Games1/Create
        public IActionResult Create()
        {
            ViewData["GenreID"] = new SelectList(_context.Genres, "GenreID", "GenreID");
            ViewData["PublisherID"] = new SelectList(_context.Publishers, "PublisherID", "PublisherID");
            return View();
        }

        // POST: Games1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GameID,Title,ReleaseDate,PLatform,Price,StockQuantity,GenreID,PublisherID")] Game game)
        {
            if (ModelState.IsValid)
            {
                _context.Add(game);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GenreID"] = new SelectList(_context.Genres, "GenreID", "GenreID", game.GenreID);
            ViewData["PublisherID"] = new SelectList(_context.Publishers, "PublisherID", "PublisherID", game.PublisherID);
            return View(game);
        }

        // GET: Games1/Edit/5
        public async Task<IActionResult> Edit(int? id)
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
            ViewData["PublisherID"] = new SelectList(_context.Publishers, "PublisherID", "PublisherID", game.PublisherID);
            return View(game);
        }

        // POST: Games1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GameID,Title,ReleaseDate,PLatform,Price,StockQuantity,GenreID,PublisherID")] Game game)
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
            ViewData["PublisherID"] = new SelectList(_context.Publishers, "PublisherID", "PublisherID", game.PublisherID);
            return View(game);
        }

        // GET: Games1/Delete/5
        public async Task<IActionResult> Delete(int? id)
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
        }

        // POST: Games1/Delete/5
        [HttpPost, ActionName("Delete")]
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
        }

        private bool GameExists(int id)
        {
          return (_context.Games?.Any(e => e.GameID == id)).GetValueOrDefault();
        }
    }
}
