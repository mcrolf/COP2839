using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameStore.Migrations
{
    /// <inheritdoc />
    public partial class _102623 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreID);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    PublisherID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Headquarters = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.PublisherID);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Platform = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    GenreID = table.Column<int>(type: "int", nullable: false),
                    PublisherID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameID);
                    table.ForeignKey(
                        name: "FK_Games_Genres_GenreID",
                        column: x => x.GenreID,
                        principalTable: "Genres",
                        principalColumn: "GenreID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Games_Publishers_PublisherID",
                        column: x => x.PublisherID,
                        principalTable: "Publishers",
                        principalColumn: "PublisherID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Open-world games where players have freedom to explore and create.", "Sandbox" },
                    { 2, "Games that emphasize shooting from a first-person perspective.", "First-Person Shooter" },
                    { 3, "Role-playing games with fast-paced action and combat elements.", "Action RPG" },
                    { 4, "Combines action gameplay with adventure elements and storytelling.", "Action-Adventure" },
                    { 5, "Simulations of real-world sports, such as soccer, basketball, and more.", "Sports" },
                    { 6, "Games that focus on navigating platforms and obstacles.", "Platformer" },
                    { 7, "Multiplayer games designed for social gatherings and fun with friends.", "Party" },
                    { 8, "Games that aim to scare and create a suspenseful atmosphere.", "Horror" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherID", "Headquarters", "Name", "WebURL" },
                values: new object[,]
                {
                    { 1, "Warsaw, Poland", "CD Projekt", "https://www.cdprojekt.com" },
                    { 2, "New York City, USA", "Rockstar Games", "https://www.rockstargames.com" },
                    { 3, "Kyoto, Japan", "Nintendo", "https://www.nintendo.com" },
                    { 4, "Montreuil, France", "Ubisoft", "https://www.ubisoft.com" },
                    { 5, "Redwood City, USA", "Electronic Arts", "https://www.ea.com" },
                    { 6, "Stockholm, Sweden", "Mojang Studios", "https://www.minecraft.net" },
                    { 7, "Santa Monica, USA", "Activision", "https://www.activision.com" },
                    { 8, "Rockville, USA", "Bethesda", "https://bethesda.net" },
                    { 9, "Redmond, USA", "Microsoft", "https://www.microsoft.com" },
                    { 10, "San Mateo, USA", "Sony Interactive Entertainment", "https://www.sie.com" },
                    { 11, "Redmond, USA", "Innersloth", "https://www.innersloth.com" },
                    { 12, "Irvine, USA", "Blizzard Entertainment", "https://www.blizzard.com" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "GenreID", "Platform", "Price", "PublisherID", "ReleaseDate", "StockQuantity", "Title" },
                values: new object[,]
                {
                    { 1, 3, 6, 29.99m, 2, new DateTime(2015, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, "The Witcher 3: Wild Hunt" },
                    { 2, 4, 0, 39.99m, 2, new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 75, "Red Dead Redemption 2" },
                    { 3, 4, 5, 49.99m, 3, new DateTime(2017, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, "The Legend of Zelda: Breath of the Wild" },
                    { 4, 3, 3, 34.99m, 1, new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, "Cyberpunk 2077" },
                    { 5, 1, 2, 19.99m, 6, new DateTime(2011, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 120, "Minecraft" },
                    { 6, 5, 3, 44.99m, 5, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, "FIFA 22" },
                    { 7, 3, 1, 37.99m, 4, new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, "Assassin's Creed Valhalla" },
                    { 8, 2, 6, 0.99m, 7, new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 150, "Call of Duty: Warzone" },
                    { 9, 6, 5, 44.99m, 3, new DateTime(2017, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 65, "Super Mario Odyssey" },
                    { 10, 4, 3, 29.99m, 2, new DateTime(2013, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, "Grand Theft Auto V" },
                    { 11, 3, 1, 24.99m, 8, new DateTime(2011, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, "The Elder Scrolls V: Skyrim" },
                    { 12, 2, 3, 49.99m, 9, new DateTime(2021, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, "Halo Infinite" },
                    { 13, 3, 2, 39.99m, 10, new DateTime(2020, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 65, "Horizon Zero Dawn" },
                    { 14, 7, 6, 4.99m, 11, new DateTime(2018, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 110, "Among Us" },
                    { 15, 2, 1, 19.99m, 12, new DateTime(2016, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 75, "Overwatch" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_GenreID",
                table: "Games",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_Games_PublisherID",
                table: "Games",
                column: "PublisherID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
