using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VideoGameStore.Admin.Models;
using VideoGameStore.Models;

namespace VideoGameStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class EmployeesController : Controller
    {
        private Repository<Employee> employeeData { get; set; }

        public EmployeesController(GameStoreContext context)
        {
            employeeData = new Repository<Employee>(context);
        }


        public IActionResult Index()
        {
            var Employees = employeeData.List(new QueryOptions<Employee>
            {
                OrderBy = c => c.LastName
            });
            return View(Employees);
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
        public ViewResult Add() => View("Employee", new Employee());


        [HttpPost]
        public IActionResult Add(Employee employee, string operation)
        {


            if (ModelState.IsValid)
            {
                employeeData.Insert(employee);
                employeeData.Save();

                TempData["message"] = $"{employee.FullName} added to Employees";
                return RedirectToAction("Index");  // PRG pattern
            }
            else
            {
                return View("Employee", employee);
            }
        }
        [HttpGet]
        public ViewResult Edit(int id) => View("Employee", employeeData.Get(id));

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            // no remote validation of Employee on edit
            if (ModelState.IsValid)
            {
                employeeData.Update(employee);
                employeeData.Save();
                TempData["message"] = $"{employee.FullName} updated.";
                return RedirectToAction("Index");  // PRG pattern
            }
            else
            {
                return View("Employee", employee);
            }
        }

        // delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var employee = employeeData.Get(new QueryOptions<Employee>
            {
                Where = a => a.EmployeeID == id
            });
            return View(employee);

        }

        [HttpPost]
        public RedirectToActionResult Delete(Employee employee)
        {
            employeeData.Delete(employee);
            employeeData.Save();
            TempData["message"] = $"{employee.FullName} removed from Employees.";
            return RedirectToAction("Index");  // PRG pattern
        }
    }
}