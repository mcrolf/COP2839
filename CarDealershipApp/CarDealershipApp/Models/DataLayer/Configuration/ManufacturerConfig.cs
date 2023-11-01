using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarDealershipApp.Models
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
                    Name = "Acura",
                    WebURL = "https://www.acura.com",
                },
                new Manufacturer
                {
                    ManufacturerID = 2,
                    Name = "Audi",
                    WebURL = "https://www.audi.com",
                },
                new Manufacturer
                {
                    ManufacturerID = 3,
                    Name = "BMW",
                    WebURL = "https://www.BMW.com",
                },
                new Manufacturer
                {
                    ManufacturerID = 4,
                    Name = "Cadillac",
                    WebURL = "https://www.Cadillac.com"
                },
                new Manufacturer
                {
                    ManufacturerID = 5,
                    Name = "Chevrolet",
                    WebURL = "https://www.chevrolet.com"
                },
                new Manufacturer
                {
                    ManufacturerID = 6,
                    Name = "Dodge",
                    WebURL = "https://www.dodge.com"
                },
                new Manufacturer
                {
                    ManufacturerID = 7,
                    Name = "Ford",
                    WebURL = "https://www.ford.com"
                },
                new Manufacturer
                {
                    ManufacturerID = 8,
                    Name = "GMC",
                    WebURL = "https://www.gmc.com"
                },
                new Manufacturer
                {
                    ManufacturerID = 9,
                    Name = "Honda",
                    WebURL = "https://www.honda.com"
                },
                new Manufacturer
                {
                    ManufacturerID = 10,
                    Name = "Hyundai",
                    WebURL = "https://www.hyundai.com"
                },
                new Manufacturer
                {
                    ManufacturerID = 11,
                    Name = "Infiniti",
                    WebURL = "https://www.infinitiusa.com"
                },
                new Manufacturer
                {
                    ManufacturerID = 12,
                    Name = "Jeep",
                    WebURL = "https://www.jeep.com"
                },
                new Manufacturer
                {
                    ManufacturerID = 13,
                    Name = "Kia",
                    WebURL = "https://www.kia.com"
                },
                new Manufacturer
                {
                    ManufacturerID = 14,
                    Name = "Lexus",
                    WebURL = "https://www.lexus.com"
                },
                new Manufacturer
                {
                    ManufacturerID = 15,
                    Name = "Lincoln",
                    WebURL = "https://www.lincoln.com"
                },
                new Manufacturer
                {
                    ManufacturerID = 16,
                    Name = "Maxda",
                    WebURL = "https://www.mazda.com"
                },
                new Manufacturer
                {
                    ManufacturerID = 17,
                    Name = "Mercedes",
                    WebURL = "https://www.mbusa.com"
                },
                new Manufacturer
                {
                    ManufacturerID = 18,
                    Name = "Mini",
                    WebURL = "https://www.miniusa.com"
                },
                new Manufacturer
                {
                    ManufacturerID = 19,
                    Name = "Mitsubishi",
                    WebURL = "https://www.mitsubishicars.com"
                },
                new Manufacturer
                {
                    ManufacturerID = 20,
                    Name = "Nissan",
                    WebURL = "https://www.Nissanusa.com"
                },
                new Manufacturer
                {
                    ManufacturerID = 21,
                    Name = "Pontiac",
                    WebURL = "https://www.pontiac.com"
                },
                new Manufacturer
                {
                    ManufacturerID = 22,
                    Name = "Porsche",
                    WebURL = "https://www.porsche.com"
                },
                new Manufacturer
                {
                    ManufacturerID = 23,
                    Name = "Saab",
                    WebURL = "https://www.saab.com"
                },
                new Manufacturer
                {
                    ManufacturerID = 24,
                    Name = "Scion",
                    WebURL = "https://www.scion.com" //redirects to toyota
                },
                new Manufacturer
                {
                    ManufacturerID = 25,
                    Name = "Subaru",
                    WebURL = "https://www.subaru.com"
                },
                new Manufacturer
                {
                    ManufacturerID = 26,
                    Name = "Toyota",
                    WebURL = "https://www.toyota.com"
                },
                new Manufacturer
                {
                    ManufacturerID = 27,
                    Name = "Volkswagen",
                    WebURL = "https://www.vw.com"
                },
                new Manufacturer
                {
                    ManufacturerID = 28,
                    Name = "Volvo",
                    WebURL = "https://www.volvo.com"
                }

                );
        }

    }
}
