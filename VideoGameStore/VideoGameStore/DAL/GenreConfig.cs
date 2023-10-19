using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VideoGameStore.Models;

namespace VideoGameStore.DAL
{
    internal class GenreConfig : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder) 
        {
            builder.HasData(
                new Genre
                {
                    GenreID = 2,
                    Name = "Adventure",
                    Description = "Roam and Explore, complete quests and interact with npc."
                },
                new Genre
                {
                    GenreID = 3,
                    Name = "Fantasy",
                    Description = "Fantasy world, magic."
                }
                );
        }
    }
}
