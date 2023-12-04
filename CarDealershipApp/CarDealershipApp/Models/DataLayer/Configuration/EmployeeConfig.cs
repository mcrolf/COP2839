using CarDealershipApp.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarDealershipApp.Models
{
    internal class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
            new Employee
            {
                EmployeeID = 1,
                FirstName = "Silent",
                LastName = "Bob",
                Position = "Sales",
                HireDate = DateTime.Today,
                Salary = 45000m

            }
            );
        }
    }
}