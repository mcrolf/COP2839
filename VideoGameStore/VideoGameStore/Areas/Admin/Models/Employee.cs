using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using VideoGameStore.Models;

namespace VideoGameStore.Admin.Models

{


    public class Employee
    {

        public int EmployeeID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public string? Position { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        public decimal Salary { get; set; }

        public string? UserID { get; set; }
        [ValidateNever]
        public User User { get; set; } = null!;

    }
}
