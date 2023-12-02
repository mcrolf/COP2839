using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VideoGameStore.Admin.Models;

namespace VideoGameStore.Models
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
            new Employee
            {
                EmployeeID = 1,
                FirstName = "Silent",
                LastName = "Bob",
                Position = "Clerk",
                HireDate = DateTime.Today,
                Salary = 45000m

            }
            );
        }
    }
}