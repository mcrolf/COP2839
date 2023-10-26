using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarDealershipApp.Models
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
            /*
              new Car
              {
                 CarID = 0,
                 Color = Color.White,
                 ManufacturerID = 0,
                 Mileage = 0,
                 Model = "",
                 StickerPrice = 0,
                 VIN = "",
                 Year = 0
              }
             */
            //******************************************
            builder.HasData(
                new Car
                {
                    CarID = 1,
                    Color = Color.White,
                    ManufacturerID = 26,
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
                    ManufacturerID = 9,
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
                    ManufacturerID = 7,
                    Mileage = 63897,
                    Model = "F-150",
                    StickerPrice = 30999,
                    VIN = "1FTFW1E52JKE09948",
                    Year = 2018
                },
                new Car
                {
                    CarID = 4,
                    Color = Color.Silver,
                    ManufacturerID = 20,
                    Mileage = 28677,
                    Model = "Altima",
                    StickerPrice = 18200,
                    VIN = "1N4BL4CV3KC117951",
                    Year = 2019
                },
                new Car
                {
                    CarID = 5,
                    Color = Color.Silver,
                    ManufacturerID = 16,
                    Mileage = 56988,
                    Model = "CX5",
                    StickerPrice = 14600,
                    VIN = "JM3KE2DY5G0601458",
                    Year = 2016
                }
                ); ;
        }
    }
}
