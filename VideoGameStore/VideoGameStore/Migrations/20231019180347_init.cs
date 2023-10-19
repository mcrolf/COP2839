using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameStore.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
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
                    WebURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublisherID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.PublisherID);
                    table.ForeignKey(
                        name: "FK_Publishers_Publishers_PublisherID1",
                        column: x => x.PublisherID1,
                        principalTable: "Publishers",
                        principalColumn: "PublisherID");
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PLatform = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
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
                    { 2, "Roam and Explore, complete quests and interact with npc.", "Adventure" },
                    { 3, "Fantasy world, magic.", "Fantasy" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherID", "Headquarters", "Name", "PublisherID1", "WebURL" },
                values: new object[,]
                {
                    { 2, "Poland", "CD Projekt", null, "cdprojekt.com" },
                    { 3, "Los Angeles", "Rockstar Games", null, "Rockstargames.com" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "GenreID", "PLatform", "Price", "PublisherID", "ReleaseDate", "StockQuantity", "Title" },
                values: new object[,]
                {
                    { 1, 3, 5, 29.99m, 2, new DateTime(2015, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "The Witcher 3" },
                    { 2, 2, 5, 34.99m, 3, new DateTime(2017, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Red Dead Redemprion 2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_GenreID",
                table: "Games",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_Games_PublisherID",
                table: "Games",
                column: "PublisherID");

            migrationBuilder.CreateIndex(
                name: "IX_Publishers_PublisherID1",
                table: "Publishers",
                column: "PublisherID1");
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
