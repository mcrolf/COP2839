using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CarDealershipApp.Models;
using static Azure.Core.HttpHeader;


namespace CarDealershipApp.DAL
{
    //******************************************
    // ManufacturerConfig uses IEntityTypeConfiguration
    //******************************************
    public class ManufacturerConfig : IEntityTypeConfiguration<Manufacturer>
    {
        public void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            //******************************************
            // init with this data
            //******************************************
            
            // TODO: Add More Manufacturers to initialized list

            builder.HasData(
                new Manufacturer
                {
                    ManufacturerID = 1,
                    Name = "Toyota",
                    WebURL = "https://www.toyota.com",
                },
                new Manufacturer
                {
                    ManufacturerID = 2,
                    Name = "Honda",
                    WebURL = "https://automobiles.honda.com",
                },
                new Manufacturer
                {
                    ManufacturerID = 3,
                    Name = "Ford",
                    WebURL = "https://www.ford.com",
                }
                );
        }

    }
}
