using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VideoGameStore.Models;

namespace VideoGameStore.DAL
{
    internal class PublisherConfig : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasData(
                new Publisher
                {
                    Name = "Rockstar Games",
                    PublisherID = 3,
                    Headquarters = "Los Angeles",
                    WebURL = "Rockstargames.com"
                },
                new Publisher
                {
                    Name = "CD Projekt",
                    PublisherID = 2,
                    Headquarters = "Poland",
                    WebURL = "cdprojekt.com"
                }
                );
        }
    }
}
