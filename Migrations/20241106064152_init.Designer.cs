﻿// <auto-generated />
using System;
using BedBankReports.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BedBankReports.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241106064152_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BedBankReports.API.Models.Domain.FileData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileExtension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MimeType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FileDatas");
                });

            modelBuilder.Entity("BedBankReports.API.Models.Domain.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HotelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6622),
                            HotelName = "GRAND PARK LARA"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6626),
                            HotelName = "CONCORDIA CELES HOTEL"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6664),
                            HotelName = "ROYAL WINGS HOTEL"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6666),
                            HotelName = "HORUS PARADISE LUXURY RESORT"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6667),
                            HotelName = "ROYAL SEGINUS"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6669),
                            HotelName = "ALARCHA HOTELS"
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6670),
                            HotelName = "NOXINN DELUXE HOTEL"
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6671),
                            HotelName = "ADALYA ELITE LARA"
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6672),
                            HotelName = "ALAN XAFIRA DELUXE RESORT"
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6673),
                            HotelName = "SEVEN SEAS GRAVEL SELECT"
                        });
                });

            modelBuilder.Entity("BedBankReports.API.Models.Domain.Rate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("B2B")
                        .HasColumnType("real");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("DiffEuro")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("real")
                        .HasComputedColumnSql("[OtherToPrice] - [OurBestPrice]");

                    b.Property<float>("DiffPercent")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("real")
                        .HasComputedColumnSql("([OtherToPrice]/[OurBestPrice])-1");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<float>("OtherToPrice")
                        .HasColumnType("real");

                    b.Property<float>("OurBestPrice")
                        .HasColumnType("real");

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.Property<float>("WebBeds")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("Rates");
                });

            modelBuilder.Entity("BedBankReports.API.Models.Domain.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<float?>("FinalCost")
                        .HasColumnType("real");

                    b.Property<float?>("FinalProfit")
                        .HasColumnType("real");

                    b.Property<float?>("FinalProfitPercent")
                        .HasColumnType("real");

                    b.Property<float?>("FinalSales")
                        .HasColumnType("real");

                    b.Property<int?>("Paxes")
                        .HasColumnType("int");

                    b.Property<int?>("ReservationCount")
                        .HasColumnType("int");

                    b.Property<int?>("RoomNights")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Sales");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6869),
                            Date = new DateOnly(2024, 10, 1),
                            FinalCost = 1500f,
                            FinalProfit = 1000f,
                            FinalProfitPercent = 66.67f,
                            FinalSales = 2500f,
                            Paxes = 50,
                            ReservationCount = 5,
                            RoomNights = 50
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6873),
                            Date = new DateOnly(2024, 10, 2),
                            FinalCost = 2000f,
                            FinalProfit = 500f,
                            FinalProfitPercent = 25f,
                            FinalSales = 2500f,
                            Paxes = 60,
                            ReservationCount = 6,
                            RoomNights = 60
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6876),
                            Date = new DateOnly(2024, 10, 3),
                            FinalCost = 1000f,
                            FinalProfit = 150f,
                            FinalProfitPercent = 15f,
                            FinalSales = 1500f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6879),
                            Date = new DateOnly(2024, 10, 4),
                            FinalCost = 4500f,
                            FinalProfit = 400f,
                            FinalProfitPercent = 8.99f,
                            FinalSales = 4900f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6882),
                            Date = new DateOnly(2024, 10, 5),
                            FinalCost = 985f,
                            FinalProfit = 65f,
                            FinalProfitPercent = 6.6f,
                            FinalSales = 1050f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6885),
                            Date = new DateOnly(2024, 10, 6),
                            FinalCost = 900f,
                            FinalProfit = 600f,
                            FinalProfitPercent = 66.67f,
                            FinalSales = 1500f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6888),
                            Date = new DateOnly(2024, 10, 7),
                            FinalCost = 900f,
                            FinalProfit = 250f,
                            FinalProfitPercent = 38.89f,
                            FinalSales = 1250f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6890),
                            Date = new DateOnly(2024, 10, 8),
                            FinalCost = 900f,
                            FinalProfit = -150f,
                            FinalProfitPercent = -16.67f,
                            FinalSales = 750f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6893),
                            Date = new DateOnly(2024, 10, 9),
                            FinalCost = 6800f,
                            FinalProfit = 1100f,
                            FinalProfitPercent = 16.18f,
                            FinalSales = 7900f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6895),
                            Date = new DateOnly(2024, 10, 10),
                            FinalCost = 4900f,
                            FinalProfit = 1080f,
                            FinalProfitPercent = 22.04f,
                            FinalSales = 5980f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 11,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6898),
                            Date = new DateOnly(2024, 10, 11),
                            FinalCost = 9600f,
                            FinalProfit = 1300f,
                            FinalProfitPercent = 13.54f,
                            FinalSales = 10900f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 12,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6900),
                            Date = new DateOnly(2024, 10, 12),
                            FinalCost = 1500f,
                            FinalProfit = 1400f,
                            FinalProfitPercent = 93.33f,
                            FinalSales = 2900f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 13,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6904),
                            Date = new DateOnly(2024, 10, 13),
                            FinalCost = 1900f,
                            FinalProfit = 840f,
                            FinalProfitPercent = 44.21f,
                            FinalSales = 2740f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 14,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6907),
                            Date = new DateOnly(2024, 10, 14),
                            FinalCost = 3250f,
                            FinalProfit = 230f,
                            FinalProfitPercent = 7.08f,
                            FinalSales = 3480f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 15,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6909),
                            Date = new DateOnly(2024, 10, 15),
                            FinalCost = 4900f,
                            FinalProfit = 450f,
                            FinalProfitPercent = 9.18f,
                            FinalSales = 5350f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 16,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6915),
                            Date = new DateOnly(2024, 10, 16),
                            FinalCost = 1500f,
                            FinalProfit = 460f,
                            FinalProfitPercent = 30.67f,
                            FinalSales = 1960f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 17,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6918),
                            Date = new DateOnly(2024, 10, 17),
                            FinalCost = 1400f,
                            FinalProfit = 90f,
                            FinalProfitPercent = 6.43f,
                            FinalSales = 1490f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 18,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6922),
                            Date = new DateOnly(2024, 10, 18),
                            FinalCost = 3900f,
                            FinalProfit = 250f,
                            FinalProfitPercent = 6.41f,
                            FinalSales = 4150f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 19,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6924),
                            Date = new DateOnly(2024, 10, 19),
                            FinalCost = 4900f,
                            FinalProfit = 140f,
                            FinalProfitPercent = 2.86f,
                            FinalSales = 5040f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 20,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6927),
                            Date = new DateOnly(2024, 10, 20),
                            FinalCost = 1600f,
                            FinalProfit = -100f,
                            FinalProfitPercent = -6.25f,
                            FinalSales = 1500f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 21,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6930),
                            Date = new DateOnly(2024, 10, 21),
                            FinalCost = 1460f,
                            FinalProfit = -70f,
                            FinalProfitPercent = -4.79f,
                            FinalSales = 1390f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 22,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6932),
                            Date = new DateOnly(2024, 10, 22),
                            FinalCost = 1500f,
                            FinalProfit = 290f,
                            FinalProfitPercent = 19.33f,
                            FinalSales = 1790f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 23,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6935),
                            Date = new DateOnly(2024, 10, 23),
                            FinalCost = 3500f,
                            FinalProfit = 150f,
                            FinalProfitPercent = 4.29f,
                            FinalSales = 3650f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 24,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6937),
                            Date = new DateOnly(2024, 10, 24),
                            FinalCost = 1100f,
                            FinalProfit = 149f,
                            FinalProfitPercent = 13.55f,
                            FinalSales = 1249f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 25,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6940),
                            Date = new DateOnly(2024, 10, 25),
                            FinalCost = 2600f,
                            FinalProfit = 190f,
                            FinalProfitPercent = 7.31f,
                            FinalSales = 2790f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 26,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6942),
                            Date = new DateOnly(2024, 10, 26),
                            FinalCost = 2250f,
                            FinalProfit = 485f,
                            FinalProfitPercent = 21.56f,
                            FinalSales = 2735f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 27,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6945),
                            Date = new DateOnly(2024, 10, 27),
                            FinalCost = 5600f,
                            FinalProfit = 380f,
                            FinalProfitPercent = 6.79f,
                            FinalSales = 5980f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 28,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6948),
                            Date = new DateOnly(2024, 10, 28),
                            FinalCost = 5100f,
                            FinalProfit = 225f,
                            FinalProfitPercent = 4.41f,
                            FinalSales = 5325f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 29,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6952),
                            Date = new DateOnly(2024, 10, 29),
                            FinalCost = 3100f,
                            FinalProfit = 850f,
                            FinalProfitPercent = 27.42f,
                            FinalSales = 3950f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 30,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6955),
                            Date = new DateOnly(2024, 10, 30),
                            FinalCost = 3500f,
                            FinalProfit = 250f,
                            FinalProfitPercent = 7.17f,
                            FinalSales = 3750f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        },
                        new
                        {
                            Id = 31,
                            CreatedDate = new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6957),
                            Date = new DateOnly(2024, 10, 31),
                            FinalCost = 4550f,
                            FinalProfit = 420f,
                            FinalProfitPercent = 9.23f,
                            FinalSales = 4970f,
                            Paxes = -1,
                            ReservationCount = -1,
                            RoomNights = -1
                        });
                });

            modelBuilder.Entity("BedBankReports.API.Models.Domain.Rate", b =>
                {
                    b.HasOne("BedBankReports.API.Models.Domain.Hotel", "Hotel")
                        .WithMany("Rates")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("BedBankReports.API.Models.Domain.Hotel", b =>
                {
                    b.Navigation("Rates");
                });
#pragma warning restore 612, 618
        }
    }
}
