using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarDealershipApp.Migrations
{
    /// <inheritdoc />
    public partial class _102623 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "Lots",
                columns: table => new
                {
                    LotID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LotName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LotAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lots", x => x.LotID);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    ManufacturerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.ManufacturerID);
                    table.ForeignKey(
                        name: "FK_Manufacturers_Manufacturers_ManufacturerID1",
                        column: x => x.ManufacturerID1,
                        principalTable: "Manufacturers",
                        principalColumn: "ManufacturerID");
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    SaleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaleDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    CarID = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.SaleID);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<int>(type: "int", nullable: false),
                    ManufacturerID = table.Column<int>(type: "int", nullable: false),
                    Mileage = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StickerPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarID);
                    table.ForeignKey(
                        name: "FK_Cars_Manufacturers_ManufacturerID",
                        column: x => x.ManufacturerID,
                        principalTable: "Manufacturers",
                        principalColumn: "ManufacturerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "ManufacturerID", "ManufacturerID1", "Name", "WebURL" },
                values: new object[,]
                {
                    { 1, null, "Acura", "https://www.acura.com" },
                    { 2, null, "Audi", "https://www.audi.com" },
                    { 3, null, "BMW", "https://www.BMW.com" },
                    { 4, null, "Cadillac", "https://www.Cadillac.com" },
                    { 5, null, "Chevrolet", "https://www.chevrolet.com" },
                    { 6, null, "Dodge", "https://www.dodge.com" },
                    { 7, null, "Ford", "https://www.ford.com" },
                    { 8, null, "GMC", "https://www.gmc.com" },
                    { 9, null, "Honda", "https://www.honda.com" },
                    { 10, null, "Hyundai", "https://www.hyundai.com" },
                    { 11, null, "Infiniti", "https://www.infinitiusa.com" },
                    { 12, null, "Jeep", "https://www.jeep.com" },
                    { 13, null, "Kia", "https://www.kia.com" },
                    { 14, null, "Lexus", "https://www.lexus.com" },
                    { 15, null, "Lincoln", "https://www.lincoln.com" },
                    { 16, null, "Maxda", "https://www.mazda.com" },
                    { 17, null, "Mercedes", "https://www.mbusa.com" },
                    { 18, null, "Mini", "https://www.miniusa.com" },
                    { 19, null, "Mitsubishi", "https://www.mitsubishicars.com" },
                    { 20, null, "Nissan", "https://www.Nissanusa.com" },
                    { 21, null, "Pontiac", "https://www.pontiac.com" },
                    { 22, null, "Porsche", "https://www.porsche.com" },
                    { 23, null, "Saab", "https://www.saab.com" },
                    { 24, null, "Scion", "https://www.scion.com" },
                    { 25, null, "Subaru", "https://www.subaru.com" },
                    { 26, null, "Toyota", "https://www.toyota.com" },
                    { 27, null, "Volkswagen", "https://www.vw.com" },
                    { 28, null, "Volvo", "https://www.volvo.com" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "Color", "ManufacturerID", "Mileage", "Model", "StickerPrice", "VIN", "Year" },
                values: new object[,]
                {
                    { 1, 2, 26, 65123, "Camry LE", 14999m, "4T1BF1FK6HU631387", 2017 },
                    { 2, 4, 9, 85976, "Civic SI", 13999m, "2HGFC1E53JH702758", 2018 },
                    { 3, 1, 7, 63897, "F-150", 30999m, "1FTFW1E52JKE09948", 2018 },
                    { 4, 3, 20, 28677, "Altima", 18200m, "1N4BL4CV3KC117951", 2019 },
                    { 5, 3, 16, 56988, "CX5", 14600m, "JM3KE2DY5G0601458", 2016 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ManufacturerID",
                table: "Cars",
                column: "ManufacturerID");

            migrationBuilder.CreateIndex(
                name: "IX_Manufacturers_ManufacturerID1",
                table: "Manufacturers",
                column: "ManufacturerID1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Lots");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Manufacturers");
        }
    }
}
