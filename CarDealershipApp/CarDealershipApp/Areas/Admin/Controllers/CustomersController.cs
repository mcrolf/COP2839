using CarDealershipApp.Areas.Admin.Models;
using CarDealershipApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VideoGameStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CustomersController : Controller
    {
        private Repository<Customer> customerData { get; set; }

        public CustomersController(CarDealerContext context)
        {
            customerData = new Repository<Customer>(context);
        }


        public IActionResult Index()
        {
            var customers = customerData.List(new QueryOptions<Customer>
            {
                OrderBy = c => c.LastName
            });
            return View(customers);
        }

        [HttpPost]
        public RedirectToActionResult Select(int id, string operation)
        {
            switch (operation.ToLower())
            {
                case "edit":
                    return RedirectToAction("Edit", new { id });
                case "delete":
                    return RedirectToAction("Delete", new { id });
                default:
                    return RedirectToAction("Index");
            }
        }
        // add
        [HttpGet]
        public ViewResult Add() => View("Customer", new Customer());


        [HttpPost]
        public IActionResult Add(Customer customer, string operation)
        {


            if (ModelState.IsValid)
            {
                customerData.Insert(customer);
                customerData.Save();

                TempData["message"] = $"{customer.FullName} added to Customers";
                return RedirectToAction("Index");  // PRG pattern
            }
            else
            {
                return View("Customer", customer);
            }
        }
        [HttpGet]
        public ViewResult Edit(int id) => View("Customer", customerData.Get(id));

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            // no remote validation of Customer on edit
            if (ModelState.IsValid)
            {
                customerData.Update(customer);
                customerData.Save();
                TempData["message"] = $"{customer.FullName} updated.";
                return RedirectToAction("Index");  // PRG pattern
            }
            else
            {
                return View("Customer", customer);
            }
        }

        // delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var customer = customerData.Get(new QueryOptions<Customer>
            {
                Where = a => a.CustomerID == id
            });
            return View("Customer", customer);

        }

        [HttpPost]
        public RedirectToActionResult Delete(Customer customer)
        {
            customerData.Delete(customer);
            customerData.Save();
            TempData["message"] = $"{customer.FullName} removed from Customers.";
            return RedirectToAction("Index");  // PRG pattern
        }

    }
}