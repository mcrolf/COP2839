using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VideoGameStore.Models
{
    internal class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasData(
                new Game
                {
                    GameID = 1,
                    Title = "The Witcher 3: Wild Hunt",
                    GenreID = 3,
                    PublisherID = 2,
                    ReleaseDate = new DateTime(2015, 5, 19),
                    Platform = Platform.Computer,
                    Price = 29.99m,
                    StockQuantity = 100
                },

                new Game
                {
                    GameID = 2,
                    Title = "Red Dead Redemption 2",
                    GenreID = 4,
                    PublisherID = 2,
                    ReleaseDate = new DateTime(2018, 10, 26),
                    Platform = Platform.Playstation,
                    Price = 39.99m,
                    StockQuantity = 75
                },

                new Game
                {
                    GameID = 3,
                    Title = "The Legend of Zelda: Breath of the Wild",
                    GenreID = 4,
                    PublisherID = 3,
                    ReleaseDate = new DateTime(2017, 3, 3),
                    Platform = Platform.Ninetndo_Switch,
                    Price = 49.99m,
                    StockQuantity = 60
                },

                new Game
                {
                    GameID = 4,
                    Title = "Cyberpunk 2077",
                    GenreID = 3,
                    PublisherID = 1,
                    ReleaseDate = new DateTime(2020, 12, 10),
                    Platform = Platform.Xbox,
                    Price = 34.99m,
                    StockQuantity = 90
                },

                new Game
                {
                    GameID = 5,
                    Title = "Minecraft",
                    GenreID = 1,
                    PublisherID = 6,
                    ReleaseDate = new DateTime(2011, 11, 18),
                    Platform = Platform.Playstation_5,
                    Price = 19.99m,
                    StockQuantity = 120
                },

                new Game
                {
                    GameID = 6,
                    Title = "FIFA 22",
                    GenreID = 5,
                    PublisherID = 5,
                    ReleaseDate = new DateTime(2021, 10, 1),
                    Platform = Platform.Xbox,
                    Price = 44.99m,
                    StockQuantity = 80
                },

                 new Game
                 {
                     GameID = 7,
                     Title = "Assassin's Creed Valhalla",
                     GenreID = 3,
                     PublisherID = 4,
                     ReleaseDate = new DateTime(2020, 11, 10),
                     Platform = Platform.Playstation_4,
                     Price = 37.99m,
                     StockQuantity = 70
                 },

                new Game
                {
                    GameID = 8,
                    Title = "Call of Duty: Warzone",
                    GenreID = 2,
                    PublisherID = 7,
                    ReleaseDate = new DateTime(2020, 3, 10),
                    Platform = Platform.Computer,
                    Price = 0.99m,
                    StockQuantity = 150
                },

                new Game
                {
                    GameID = 9,
                    Title = "Super Mario Odyssey",
                    GenreID = 6,
                    PublisherID = 3,
                    ReleaseDate = new DateTime(2017, 10, 27),
                    Platform = Platform.Ninetndo_Switch,
                    Price = 44.99m,
                    StockQuantity = 65
                },

                new Game
                {
                    GameID = 10,
                    Title = "Grand Theft Auto V",
                    GenreID = 4,
                    PublisherID = 2,
                    ReleaseDate = new DateTime(2013, 9, 17),
                    Platform = Platform.Xbox,
                    Price = 29.99m,
                    StockQuantity = 85
                },

                new Game
                {
                    GameID = 11,
                    Title = "The Elder Scrolls V: Skyrim",
                    GenreID = 3,
                    PublisherID = 8,
                    ReleaseDate = new DateTime(2011, 11, 11),
                    Platform = Platform.Playstation_4,
                    Price = 24.99m,
                    StockQuantity = 55
                },

                new Game
                {
                    GameID = 12,
                    Title = "Halo Infinite",
                    GenreID = 2,
                    PublisherID = 9,
                    ReleaseDate = new DateTime(2021, 12, 8),
                    Platform = Platform.Xbox,
                    Price = 49.99m,
                    StockQuantity = 40
                },

                 new Game
                 {
                     GameID = 13,
                     Title = "Horizon Zero Dawn",
                     GenreID = 3,
                     PublisherID = 10,
                     ReleaseDate = new DateTime(2020, 8, 7),
                     Platform = Platform.Playstation_5,
                     Price = 39.99m,
                     StockQuantity = 65
                 },

                new Game
                {
                    GameID = 14,
                    Title = "Among Us",
                    GenreID = 7,
                    PublisherID = 11,
                    ReleaseDate = new DateTime(2018, 6, 15),
                    Platform = Platform.Computer,
                    Price = 4.99m,
                    StockQuantity = 110
                },


                new Game
                {
                    GameID = 15,
                    Title = "Overwatch",
                    GenreID = 2,
                    PublisherID = 12,
                    ReleaseDate = new DateTime(2016, 5, 24),
                    Platform = Platform.Playstation_4,
                    Price = 19.99m,
                    StockQuantity = 75
                });
        }
    }
}