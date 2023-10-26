using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VideoGameStore.Models
{
    internal class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(
                                new Genre
                                {
                                    GenreID = 1,
                                    Name = "Sandbox",
                                    Description = "Open-world games where players have freedom to explore and create."
                                },

                                new Genre
                                {
                                    GenreID = 2,
                                    Name = "First-Person Shooter",
                                    Description = "Games that emphasize shooting from a first-person perspective."
                                },

                                new Genre
                                {
                                    GenreID = 3,
                                    Name = "Action RPG",
                                    Description = "Role-playing games with fast-paced action and combat elements."
                                },

                                new Genre
                                {
                                    GenreID = 4,
                                    Name = "Action-Adventure",
                                    Description = "Combines action gameplay with adventure elements and storytelling."
                                },

                                new Genre
                                {
                                    GenreID = 5,
                                    Name = "Sports",
                                    Description = "Simulations of real-world sports, such as soccer, basketball, and more."
                                },

                                new Genre
                                {
                                    GenreID = 6,
                                    Name = "Platformer",
                                    Description = "Games that focus on navigating platforms and obstacles."
                                },

                                new Genre
                                {
                                    GenreID = 7,
                                    Name = "Party",
                                    Description = "Multiplayer games designed for social gatherings and fun with friends."
                                },

                                new Genre
                                {
                                    GenreID = 8,
                                    Name = "Horror",
                                    Description = "Games that aim to scare and create a suspenseful atmosphere."
                                }
                );
        }
    }
}