using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VideoGameStore.Models;
using static Azure.Core.HttpHeader;

namespace VideoGameStore.DAL
{
    internal class GameConfig : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasData(
                new Game
                {
                    GameID = 1,
                    Title = "The Witcher 3",
                    GenreID = 3,
                    PublisherID = 2,
                    ReleaseDate = new DateTime(2015, 5, 19),
                    PLatform = PLatform.PC,
                    Price = 29.99m,
                    StockQuantity = 10,
                },
                new Game
                {
                    GameID = 2,
                    Title = "Red Dead Redemprion 2",
                    GenreID = 2,
                    PublisherID = 3,
                    ReleaseDate = new DateTime(2017, 6, 14),
                    PLatform = PLatform.PC,
                    Price = 34.99m,
                    StockQuantity = 10,
                }
                );

        }
    }
}
