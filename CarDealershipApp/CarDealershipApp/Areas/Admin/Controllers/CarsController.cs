using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarDealershipApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace CarDealershipApp.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class CarsController : Controller
    {
        private readonly CarDealerContext _context;

        public CarsController(CarDealerContext context)
        {
            _context = context;
        }

        //-----------------------------------
        // GET: Admin/Cars
        //-----------------------------------
        public async Task<IActionResult> Index()
        {
            var carDealerContext = _context.Cars.Include(c => c.Manufacturer);
            return View(await carDealerContext.ToListAsync());
        }

        //---------------------------------------
        // GET: Admin/Cars/Details/5
        //---------------------------------------
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cars == null)
            {
                return NotFound();
            }

            var car = await _context.Cars
                .Include(c => c.Manufacturer)
                .FirstOrDefaultAsync(m => m.CarID == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        //--------------------------------
        // GET: Admin/Cars/Create
        //--------------------------------
        public IActionResult Create()
        {
            ViewData["ManufacturerID"] = new SelectList(_context.Manufacturers, "ManufacturerID", "ManufacturerID");
            return View();
        }

        //----------------------------------------------------------------------------------------------
        // POST: Admin/Cars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //----------------------------------------------------------------------------------------------
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CarID,Color,ManufacturerID,Mileage,CarModel,StickerPrice,VIN,Year")] Car car)
        {
            if (ModelState.IsValid)
            {
                _context.Add(car);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ManufacturerID"] = new SelectList(_context.Manufacturers, "ManufacturerID", "ManufacturerID", car.ManufacturerID);
            return View(car);
        }

        //-------------------------------------
        // GET: Admin/Cars/Edit/5
        //-------------------------------------
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Cars == null)
            {
                return NotFound();
            }

            var car = await _context.Cars.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }
            ViewData["ManufacturerID"] = new SelectList(_context.Manufacturers, "ManufacturerID", "ManufacturerID", car.ManufacturerID);
            return View(car);
        }

        //-------------------------------------------------------------------------------------------
        // POST: Admin/Cars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //-------------------------------------------------------------------------------------------
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CarID,Color,ManufacturerID,Mileage,CarModel,StickerPrice,VIN,Year")] Car car)
        {
            if (id != car.CarID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(car);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarExists(car.CarID))
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
            ViewData["ManufacturerID"] = new SelectList(_context.Manufacturers, "ManufacturerID", "ManufacturerID", car.ManufacturerID);
            return View(car);
        }

        //--------------------------------------
        // GET: Admin/Cars/Delete/5
        //--------------------------------------
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Cars == null)
            {
                return NotFound();
            }

            var car = await _context.Cars
                .Include(c => c.Manufacturer)
                .FirstOrDefaultAsync(m => m.CarID == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        //-------------------------------------
        // POST: Admin/Cars/Delete/5
        //-------------------------------------
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Cars == null)
            {
                return Problem("Entity set 'CarDealerContext.Cars'  is null.");
            }
            var car = await _context.Cars.FindAsync(id);
            if (car != null)
            {
                _context.Cars.Remove(car);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarExists(int id)
        {
          return (_context.Cars?.Any(e => e.CarID == id)).GetValueOrDefault();
        }
    }
}
