using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarDealershipApp.Areas.Admin.Models;
using CarDealershipApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace CarDealershipApp.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class CarsController : Controller
    {
        private Repository<Car> carData;
        private Repository<Manufacturer> manufacturerData;

        public CarsController(CarDealerContext context)
        {
            carData = new Repository<Car>(context);
            manufacturerData = new Repository<Manufacturer>(context);
        }

        //-----------------------------------
        // GET: Admin/Cars
        //-----------------------------------
        public IActionResult Index()
        {
            var cars = carData.List(new QueryOptions<Car>
            {
                Includes = "Manufacturer",
                OrderBy = g => g.Year

            });
            return View(cars);
        }

        //---------------------------------------
        // GET: Admin/Cars/Details/5
        //---------------------------------------
        public IActionResult Details(int? id)
        {
            if (id == null || carData == null)
            {
                return NotFound();
            }

            var car = carData.Get(new QueryOptions<Car>
            {
                Includes = "Manufacturer"
            });

            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        //--------------------------------
        // GET: Admin/Cars/Create
        //--------------------------------
        [HttpGet]
        public IActionResult Create()
        {

            var vm = new CarViewModel();
            LoadViewData(vm);
            return View("Create", vm);
        }

        //----------------------------------------------------------------------------------------------
        // POST: Admin/Cars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //----------------------------------------------------------------------------------------------
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CarViewModel vm)
        {
            if (ModelState.IsValid)
            {
                carData.Insert(vm.car);
                carData.Save();
                TempData["message"] = $"{vm.car.Year} {vm.car.Manufacturer} {vm.car.CarModel} added to the Cars List";
                return RedirectToAction("Index");
            }
            else
            {
                LoadViewData(vm);
                return View("Create");

            }
        }

        //-------------------------------------
        // GET: Admin/Cars/Edit/5
        //-------------------------------------
        public IActionResult Edit(int id)
        {
            var vm = new CarViewModel
            {
                car = GetCar(id)
            };

            if (vm.car == null)
            {
                return NotFound();
            }
            LoadViewData(vm);

            return View("Edit", vm);
        }

        //-------------------------------------------------------------------------------------------
        // POST: Admin/Cars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //-------------------------------------------------------------------------------------------
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CarViewModel vm)
        {
            if (vm.car == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    carData.Update(vm.car);
                    carData.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarExists(vm.car.CarID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                TempData["message"] = $"{vm.car.Year} {vm.car.Manufacturer} {vm.car.CarModel} edited";
                return RedirectToAction(nameof(Edit));
            }
            return View("Edit", vm.car.CarID);
        }

        //--------------------------------------
        // GET: Admin/Cars/Delete/5
        //--------------------------------------
        [HttpGet]
        public IActionResult Delete(int id)
        {

            var vm = new CarViewModel
            {
                car = GetCar(id)
            };

            if (vm.car == null)
            {
                return NotFound();
            }

            return View("Delete", vm.car);
        }

        //-------------------------------------
        // POST: Admin/Cars/Delete/5
        //-------------------------------------
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Car car)
        {
            if (carData == null)
            {
                return Problem("Entity set 'Repository<Car> carData'  is null.");
            }
            var carToDelete = carData.Get(car.CarID);
            if (carToDelete != null)
            {
                carData.Delete(carToDelete);
                carData.Save();
                TempData["message"] = $"{carToDelete.Year} {carToDelete.Manufacturer} {carToDelete.CarModel} removed from inventory";
            }

            return RedirectToAction(nameof(Delete));

        }

        private void LoadViewData(CarViewModel vm)
        {
            vm.manufacturers = manufacturerData.List(new QueryOptions<Manufacturer> { OrderBy = p => p.Name });
        }

        private Car GetCar(int id)
        {
            return carData.Get(new QueryOptions<Car>
            {
                Where = b => b.CarID == id,
                Includes = "Manufacturer"
            }) ?? new Car();
        }

        private bool CarExists(int id)
        {
            if (carData.Get(id) == null)
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
