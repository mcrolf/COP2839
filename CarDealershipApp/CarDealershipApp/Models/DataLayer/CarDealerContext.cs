using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using CarDealershipApp.Areas.Admin.Models;

namespace CarDealershipApp.Models
{
    public class CarDealerContext : IdentityDbContext<User>
    {
        public CarDealerContext(DbContextOptions<CarDealerContext> options) : base(options) { }

        //******************************************
        // creates tables for each model type
        //******************************************
        public DbSet<Car> Cars { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Manufacturer> Manufacturers { get; set; } = null!;

        //******************************************
        // build model
        //******************************************
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TODO: Add model builder for
            //       Employee, Lot, etc...

            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CarConfig());
            modelBuilder.ApplyConfiguration(new ManufacturerConfig());
            modelBuilder.ApplyConfiguration(new EmployeeConfig());
            modelBuilder.ApplyConfiguration(new CustomerConfig());
        }
    }
}
