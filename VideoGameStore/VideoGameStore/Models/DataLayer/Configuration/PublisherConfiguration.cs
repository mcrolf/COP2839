using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VideoGameStore.Models
{
    internal class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasData(
                                new Publisher
                                {
                                    PublisherID = 1,
                                    Name = "CD Projekt",
                                    Headquarters = "Warsaw, Poland",
                                    WebURL = "https://www.cdprojekt.com"
                                },

                                new Publisher
                                {
                                    PublisherID = 2,
                                    Name = "Rockstar Games",
                                    Headquarters = "New York City, USA",
                                    WebURL = "https://www.rockstargames.com"
                                },

                                new Publisher
                                {
                                    PublisherID = 3,
                                    Name = "Nintendo",
                                    Headquarters = "Kyoto, Japan",
                                    WebURL = "https://www.nintendo.com"
                                },

                                new Publisher
                                {
                                    PublisherID = 4,
                                    Name = "Ubisoft",
                                    Headquarters = "Montreuil, France",
                                    WebURL = "https://www.ubisoft.com"
                                },

                                new Publisher
                                {
                                    PublisherID = 5,
                                    Name = "Electronic Arts",
                                    Headquarters = "Redwood City, USA",
                                    WebURL = "https://www.ea.com"
                                },


                                new Publisher
                                {
                                    PublisherID = 6,
                                    Name = "Mojang Studios",
                                    Headquarters = "Stockholm, Sweden",
                                    WebURL = "https://www.minecraft.net"
                                },


                                 new Publisher
                                 {
                                     PublisherID = 7,
                                     Name = "Activision",
                                     Headquarters = "Santa Monica, USA",
                                     WebURL = "https://www.activision.com"
                                 },

                                new Publisher
                                {
                                    PublisherID = 8,
                                    Name = "Bethesda",
                                    Headquarters = "Rockville, USA",
                                    WebURL = "https://bethesda.net"
                                },

                                new Publisher
                                {
                                    PublisherID = 9,
                                    Name = "Microsoft",
                                    Headquarters = "Redmond, USA",
                                    WebURL = "https://www.microsoft.com"
                                },

                                new Publisher
                                {
                                    PublisherID = 10,
                                    Name = "Sony Interactive Entertainment",
                                    Headquarters = "San Mateo, USA",
                                    WebURL = "https://www.sie.com"
                                },

                                new Publisher
                                {
                                    PublisherID = 11,
                                    Name = "Innersloth",
                                    Headquarters = "Redmond, USA",
                                    WebURL = "https://www.innersloth.com"
                                },

                                new Publisher
                                {
                                    PublisherID = 12,
                                    Name = "Blizzard Entertainment",
                                    Headquarters = "Irvine, USA",
                                    WebURL = "https://www.blizzard.com"
                                }


            );


        }
    }
}