using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VideoGameStore.Admin.Models;

namespace VideoGameStore.Models
{
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
            new Customer
            {
                CustomerID = 1,
                FirstName = "John",
                LastName = "Doe",
                Address1 = "123 Main St",
                Address2 = "Apt 45",
                City = "Anytown",
                State = "CA",
                Zipcode = "12345"

            },
            new Customer
            {
                CustomerID = 2,
                FirstName = "Alice",
                LastName = "Smith",
                Address1 = "456 Oak St",
                Address2 = "",
                City = "Another City",
                State = "NY",
                Zipcode = "6789"

            },
            new Customer
            {
                CustomerID = 3,
                FirstName = "Bob",
                LastName = "Johnson",
                Address1 = "789 Pine St",
                Address2 = "Suite 101",
                City = "Yet Another City",
                State = "TX",
                Zipcode = "54321"

            }
            );
        }
    }
}
