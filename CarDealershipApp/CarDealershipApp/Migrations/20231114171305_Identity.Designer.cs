﻿// <auto-generated />
using System;
using CarDealershipApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarDealershipApp.Migrations
{
    [DbContext(typeof(CarDealerContext))]
    [Migration("20231114171305_Identity")]
    partial class Identity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("CarModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Color")
                        .HasColumnType("int");

                    b.Property<int>("ManufacturerID")
                        .HasColumnType("int");

                    b.Property<int>("Mileage")
                        .HasColumnType("int");

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
                            CarModel = "Camry LE",
                            Color = 2,
                            ManufacturerID = 26,
                            Mileage = 65123,
                            StickerPrice = 14999m,
                            VIN = "4T1BF1FK6HU631387",
                            Year = 2017
                        },
                        new
                        {
                            CarID = 2,
                            CarModel = "Civic SI",
                            Color = 4,
                            ManufacturerID = 9,
                            Mileage = 85976,
                            StickerPrice = 13999m,
                            VIN = "2HGFC1E53JH702758",
                            Year = 2018
                        },
                        new
                        {
                            CarID = 3,
                            CarModel = "F-150",
                            Color = 1,
                            ManufacturerID = 7,
                            Mileage = 63897,
                            StickerPrice = 30999m,
                            VIN = "1FTFW1E52JKE09948",
                            Year = 2018
                        },
                        new
                        {
                            CarID = 4,
                            CarModel = "Altima",
                            Color = 3,
                            ManufacturerID = 20,
                            Mileage = 28677,
                            StickerPrice = 18200m,
                            VIN = "1N4BL4CV3KC117951",
                            Year = 2019
                        },
                        new
                        {
                            CarID = 5,
                            CarModel = "CX5",
                            Color = 3,
                            ManufacturerID = 16,
                            Mileage = 56988,
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

            modelBuilder.Entity("CarDealershipApp.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CarDealershipApp.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CarDealershipApp.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarDealershipApp.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CarDealershipApp.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarDealershipApp.Models.Manufacturer", b =>
                {
                    b.Navigation("Manufacturers");
                });
#pragma warning restore 612, 618
        }
    }
}
