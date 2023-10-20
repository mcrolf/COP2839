using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CarDealershipApp.Models;
using static Azure.Core.HttpHeader;


namespace CarDealershipApp.DAL
{
    //******************************************
    // CarConfig uses IEntityTypeConfiguration
    //******************************************
    public class CarConfig : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            //******************************************
            // build with this initialized data
            //******************************************
            builder.HasData(
                new Car
                {
                    CarID = 1,
                    Color = Color.White,
                    ManufacturerID = 1,
                    Mileage = 65123,
                    Model = "Camry LE",
                    StickerPrice = 14999,
                    VIN = "4T1BF1FK6HU631387",
                    Year = 2017
                },
                new Car
                {
                    CarID = 2,
                    Color = Color.Blue,
                    ManufacturerID = 2,
                    Mileage = 85976,
                    Model = "Civic SI",
                    StickerPrice = 13999,
                    VIN = "2HGFC1E53JH702758",
                    Year = 2018
                },
                new Car
                {
                    CarID = 3,
                    Color = Color.Black,
                    ManufacturerID = 3,
                    Mileage = 63897,
                    Model = "F-150",
                    StickerPrice = 30999,
                    VIN = "1FTFW1E52JKE09948",
                    Year = 2018
                }
                );
        }
    }
}
