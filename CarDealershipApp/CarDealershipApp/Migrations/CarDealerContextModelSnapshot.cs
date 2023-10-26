﻿// <auto-generated />
using System;
using CarDealershipApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarDealershipApp.Migrations
{
    [DbContext(typeof(CarDealerContext))]
    partial class CarDealerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarDealershipApp.Models.Car", b =>
                {
                    b.Property<int>("CarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarID"));

                    b.Property<int>("Color")
                        .HasColumnType("int");

                    b.Property<int>("ManufacturerID")
                        .HasColumnType("int");

                    b.Property<int>("Mileage")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("StickerPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("VIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("CarID");

                    b.HasIndex("ManufacturerID");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            CarID = 1,
                            Color = 2,
                            ManufacturerID = 26,
                            Mileage = 65123,
                            Model = "Camry LE",
                            StickerPrice = 14999m,
                            VIN = "4T1BF1FK6HU631387",
                            Year = 2017
                        },
                        new
                        {
                            CarID = 2,
                            Color = 4,
                            ManufacturerID = 9,
                            Mileage = 85976,
                            Model = "Civic SI",
                            StickerPrice = 13999m,
                            VIN = "2HGFC1E53JH702758",
                            Year = 2018
                        },
                        new
                        {
                            CarID = 3,
                            Color = 1,
                            ManufacturerID = 7,
                            Mileage = 63897,
                            Model = "F-150",
                            StickerPrice = 30999m,
                            VIN = "1FTFW1E52JKE09948",
                            Year = 2018
                        },
                        new
                        {
                            CarID = 4,
                            Color = 3,
                            ManufacturerID = 20,
                            Mileage = 28677,
                            Model = "Altima",
                            StickerPrice = 18200m,
                            VIN = "1N4BL4CV3KC117951",
                            Year = 2019
                        },
                        new
                        {
                            CarID = 5,
                            Color = 3,
                            ManufacturerID = 16,
                            Mileage = 56988,
                            Model = "CX5",
                            StickerPrice = 14600m,
                            VIN = "JM3KE2DY5G0601458",
                            Year = 2016
                        });
                });

            modelBuilder.Entity("CarDealershipApp.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CarDealershipApp.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"));

                    b.Property<string>("ContactInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CarDealershipApp.Models.Lot", b =>
                {
                    b.Property<int>("LotID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LotID"));

                    b.Property<string>("LotAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LotName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LotID");

                    b.ToTable("Lots");
                });

            modelBuilder.Entity("CarDealershipApp.Models.Manufacturer", b =>
                {
                    b.Property<int>("ManufacturerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ManufacturerID"));

                    b.Property<int?>("ManufacturerID1")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ManufacturerID");

                    b.HasIndex("ManufacturerID1");

                    b.ToTable("Manufacturers");

                    b.HasData(
                        new
                        {
                            ManufacturerID = 1,
                            Name = "Acura",
                            WebURL = "https://www.acura.com"
                        },
                        new
                        {
                            ManufacturerID = 2,
                            Name = "Audi",
                            WebURL = "https://www.audi.com"
                        },
                        new
                        {
                            ManufacturerID = 3,
                            Name = "BMW",
                            WebURL = "https://www.BMW.com"
                        },
                        new
                        {
                            ManufacturerID = 4,
                            Name = "Cadillac",
                            WebURL = "https://www.Cadillac.com"
                        },
                        new
                        {
                            ManufacturerID = 5,
                            Name = "Chevrolet",
                            WebURL = "https://www.chevrolet.com"
                        },
                        new
                        {
                            ManufacturerID = 6,
                            Name = "Dodge",
                            WebURL = "https://www.dodge.com"
                        },
                        new
                        {
                            ManufacturerID = 7,
                            Name = "Ford",
                            WebURL = "https://www.ford.com"
                        },
                        new
                        {
                            ManufacturerID = 8,
                            Name = "GMC",
                            WebURL = "https://www.gmc.com"
                        },
                        new
                        {
                            ManufacturerID = 9,
                            Name = "Honda",
                            WebURL = "https://www.honda.com"
                        },
                        new
                        {
                            ManufacturerID = 10,
                            Name = "Hyundai",
                            WebURL = "https://www.hyundai.com"
                        },
                        new
                        {
                            ManufacturerID = 11,
                            Name = "Infiniti",
                            WebURL = "https://www.infinitiusa.com"
                        },
                        new
                        {
                            ManufacturerID = 12,
                            Name = "Jeep",
                            WebURL = "https://www.jeep.com"
                        },
                        new
                        {
                            ManufacturerID = 13,
                            Name = "Kia",
                            WebURL = "https://www.kia.com"
                        },
                        new
                        {
                            ManufacturerID = 14,
                            Name = "Lexus",
                            WebURL = "https://www.lexus.com"
                        },
                        new
                        {
                            ManufacturerID = 15,
                            Name = "Lincoln",
                            WebURL = "https://www.lincoln.com"
                        },
                        new
                        {
                            ManufacturerID = 16,
                            Name = "Maxda",
                            WebURL = "https://www.mazda.com"
                        },
                        new
                        {
                            ManufacturerID = 17,
                            Name = "Mercedes",
                            WebURL = "https://www.mbusa.com"
                        },
                        new
                        {
                            ManufacturerID = 18,
                            Name = "Mini",
                            WebURL = "https://www.miniusa.com"
                        },
                        new
                        {
                            ManufacturerID = 19,
                            Name = "Mitsubishi",
                            WebURL = "https://www.mitsubishicars.com"
                        },
                        new
                        {
                            ManufacturerID = 20,
                            Name = "Nissan",
                            WebURL = "https://www.Nissanusa.com"
                        },
                        new
                        {
                            ManufacturerID = 21,
                            Name = "Pontiac",
                            WebURL = "https://www.pontiac.com"
                        },
                        new
                        {
                            ManufacturerID = 22,
                            Name = "Porsche",
                            WebURL = "https://www.porsche.com"
                        },
                        new
                        {
                            ManufacturerID = 23,
                            Name = "Saab",
                            WebURL = "https://www.saab.com"
                        },
                        new
                        {
                            ManufacturerID = 24,
                            Name = "Scion",
                            WebURL = "https://www.scion.com"
                        },
                        new
                        {
                            ManufacturerID = 25,
                            Name = "Subaru",
                            WebURL = "https://www.subaru.com"
                        },
                        new
                        {
                            ManufacturerID = 26,
                            Name = "Toyota",
                            WebURL = "https://www.toyota.com"
                        },
                        new
                        {
                            ManufacturerID = 27,
                            Name = "Volkswagen",
                            WebURL = "https://www.vw.com"
                        },
                        new
                        {
                            ManufacturerID = 28,
                            Name = "Volvo",
                            WebURL = "https://www.volvo.com"
                        });
                });

            modelBuilder.Entity("CarDealershipApp.Models.Sale", b =>
                {
                    b.Property<int>("SaleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleID"));

                    b.Property<int>("CarID")
                        .HasColumnType("int");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("PaymentMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SaleDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SaleID");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("CarDealershipApp.Models.Car", b =>
                {
                    b.HasOne("CarDealershipApp.Models.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("CarDealershipApp.Models.Manufacturer", b =>
                {
                    b.HasOne("CarDealershipApp.Models.Manufacturer", null)
                        .WithMany("Manufacturers")
                        .HasForeignKey("ManufacturerID1");
                });

            modelBuilder.Entity("CarDealershipApp.Models.Manufacturer", b =>
                {
                    b.Navigation("Manufacturers");
                });
#pragma warning restore 612, 618
        }
    }
}
