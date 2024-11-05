using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BedBankReports.API.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FinalCost = table.Column<float>(type: "real", nullable: true),
                    FinalSales = table.Column<float>(type: "real", nullable: true),
                    FinalProfit = table.Column<float>(type: "real", nullable: true),
                    FinalProfitPercent = table.Column<float>(type: "real", nullable: true),
                    RoomNights = table.Column<int>(type: "int", nullable: true),
                    Paxes = table.Column<int>(type: "int", nullable: true),
                    ReservationCount = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    RoomType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    B2B = table.Column<float>(type: "real", nullable: false),
                    WebBeds = table.Column<float>(type: "real", nullable: false),
                    OurBestPrice = table.Column<float>(type: "real", nullable: false),
                    OtherToPrice = table.Column<float>(type: "real", nullable: false),
                    DiffEuro = table.Column<float>(type: "real", nullable: false),
                    DiffPercent = table.Column<float>(type: "real", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rates_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "HotelName" },
                values: new object[,]
                {
                    { 1, "GRAND PARK LARA" },
                    { 2, "CONCORDIA CELES HOTEL" },
                    { 3, "ROYAL WINGS HOTEL" },
                    { 4, "HORUS PARADISE LUXURY RESORT" },
                    { 5, "ROYAL SEGINUS" },
                    { 6, "ALARCHA HOTELS" },
                    { 7, "NOXINN DELUXE HOTEL" },
                    { 8, "ADALYA ELITE LARA" },
                    { 9, "ALAN XAFIRA DELUXE RESORT" },
                    { 10, "SEVEN SEAS GRAVEL SELECT" }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "Date", "FinalCost", "FinalProfit", "FinalProfitPercent", "FinalSales", "Paxes", "ReservationCount", "RoomNights" },
                values: new object[,]
                {
                    { 1, new DateOnly(2024, 10, 1), 1500f, 1000f, 66.67f, 2500f, 50, 5, 50 },
                    { 2, new DateOnly(2024, 10, 2), 2000f, 500f, 25f, 2500f, 60, 6, 60 },
                    { 3, new DateOnly(2024, 10, 3), 1000f, 150f, 15f, 1500f, -1, -1, -1 },
                    { 4, new DateOnly(2024, 10, 4), 4500f, 400f, 8.99f, 4900f, -1, -1, -1 },
                    { 5, new DateOnly(2024, 10, 5), 985f, 65f, 6.6f, 1050f, -1, -1, -1 },
                    { 6, new DateOnly(2024, 10, 6), 900f, 600f, 66.67f, 1500f, -1, -1, -1 },
                    { 7, new DateOnly(2024, 10, 7), 900f, 250f, 38.89f, 1250f, -1, -1, -1 },
                    { 8, new DateOnly(2024, 10, 8), 900f, -150f, -16.67f, 750f, -1, -1, -1 },
                    { 9, new DateOnly(2024, 10, 9), 6800f, 1100f, 16.18f, 7900f, -1, -1, -1 },
                    { 10, new DateOnly(2024, 10, 10), 4900f, 1080f, 22.04f, 5980f, -1, -1, -1 },
                    { 11, new DateOnly(2024, 10, 11), 9600f, 1300f, 13.54f, 10900f, -1, -1, -1 },
                    { 12, new DateOnly(2024, 10, 12), 1500f, 1400f, 93.33f, 2900f, -1, -1, -1 },
                    { 13, new DateOnly(2024, 10, 13), 1900f, 840f, 44.21f, 2740f, -1, -1, -1 },
                    { 14, new DateOnly(2024, 10, 14), 3250f, 230f, 7.08f, 3480f, -1, -1, -1 },
                    { 15, new DateOnly(2024, 10, 15), 4900f, 450f, 9.18f, 5350f, -1, -1, -1 },
                    { 16, new DateOnly(2024, 10, 16), 1500f, 460f, 30.67f, 1960f, -1, -1, -1 },
                    { 17, new DateOnly(2024, 10, 17), 1400f, 90f, 6.43f, 1490f, -1, -1, -1 },
                    { 18, new DateOnly(2024, 10, 18), 3900f, 250f, 6.41f, 4150f, -1, -1, -1 },
                    { 19, new DateOnly(2024, 10, 19), 4900f, 140f, 2.86f, 5040f, -1, -1, -1 },
                    { 20, new DateOnly(2024, 10, 20), 1600f, -100f, -6.25f, 1500f, -1, -1, -1 },
                    { 21, new DateOnly(2024, 10, 21), 1460f, -70f, -4.79f, 1390f, -1, -1, -1 },
                    { 22, new DateOnly(2024, 10, 22), 1500f, 290f, 19.33f, 1790f, -1, -1, -1 },
                    { 23, new DateOnly(2024, 10, 23), 3500f, 150f, 4.29f, 3650f, -1, -1, -1 },
                    { 24, new DateOnly(2024, 10, 24), 1100f, 149f, 13.55f, 1249f, -1, -1, -1 },
                    { 25, new DateOnly(2024, 10, 25), 2600f, 190f, 7.31f, 2790f, -1, -1, -1 },
                    { 26, new DateOnly(2024, 10, 26), 2250f, 485f, 21.56f, 2735f, -1, -1, -1 },
                    { 27, new DateOnly(2024, 10, 27), 5600f, 380f, 6.79f, 5980f, -1, -1, -1 },
                    { 28, new DateOnly(2024, 10, 28), 5100f, 225f, 4.41f, 5325f, -1, -1, -1 },
                    { 29, new DateOnly(2024, 10, 29), 3100f, 850f, 27.42f, 3950f, -1, -1, -1 },
                    { 30, new DateOnly(2024, 10, 30), 3500f, 250f, 7.17f, 3750f, -1, -1, -1 },
                    { 31, new DateOnly(2024, 10, 31), 4550f, 420f, 9.23f, 4970f, -1, -1, -1 }
                });

            migrationBuilder.InsertData(
                table: "Rates",
                columns: new[] { "Id", "B2B", "DiffEuro", "DiffPercent", "EndDate", "HotelId", "OtherToPrice", "OurBestPrice", "RoomType", "StartDate", "WebBeds" },
                values: new object[,]
                {
                    { 1, 380f, 225f, 59.2f, new DateOnly(2025, 4, 28), 1, 604.97f, 380f, "Std Room", new DateOnly(2025, 4, 21), 647.84f },
                    { 2, 980f, 63f, 6.5f, new DateOnly(2025, 6, 23), 1, 1043.34f, 980f, "Std Room", new DateOnly(2025, 6, 16), 1121.26f },
                    { 3, 1080f, 194f, 18f, new DateOnly(2025, 8, 11), 1, 1274.1f, 1080f, "Std Room", new DateOnly(2025, 8, 4), 1370.4f },
                    { 4, 1180f, -78f, -6.9f, new DateOnly(2025, 9, 29), 1, 1043.3f, 1121.3f, "Std Room", new DateOnly(2025, 9, 22), 1121.3f },
                    { 5, 480f, 66f, 13.7f, new DateOnly(2025, 4, 28), 2, 545.9f, 480f, "Std Room", new DateOnly(2025, 4, 21), 616.1f },
                    { 6, 980f, -106f, -11.8f, new DateOnly(2025, 6, 23), 2, 793.1f, 898.9f, "Std Room", new DateOnly(2025, 6, 16), 898.9f },
                    { 7, 980f, -106f, -11.8f, new DateOnly(2025, 6, 23), 2, 793.1f, 898.9f, "Std Room", new DateOnly(2025, 6, 16), 898.9f },
                    { 8, 1080f, -47f, -4.4f, new DateOnly(2025, 8, 11), 2, 1032.5f, 1080f, "Std Room", new DateOnly(2025, 8, 4), 1170.4f },
                    { 9, 780f, 36f, 4.6f, new DateOnly(2025, 9, 29), 2, 816.2f, 780f, "Std Room", new DateOnly(2025, 9, 22), 923.2f },
                    { 10, 2080f, 20f, 1.8f, new DateOnly(2025, 4, 28), 3, 1151.5f, 1131.3f, "Land View", new DateOnly(2025, 4, 21), 1131.3f },
                    { 11, 2180f, 13f, 0.7f, new DateOnly(2025, 6, 23), 3, 1873f, 1860.1f, "Land View", new DateOnly(2025, 6, 16), 1860.1f },
                    { 12, 2280f, 11f, 0.5f, new DateOnly(2025, 8, 11), 3, 2287.1f, 2276.1f, "Land View", new DateOnly(2025, 8, 4), 2276.1f },
                    { 13, 2380f, 14f, 0.8f, new DateOnly(2025, 9, 29), 3, 1811.2f, 1797.4f, "Land View", new DateOnly(2025, 9, 22), 1797.4f },
                    { 14, 400f, 190f, 47.6f, new DateOnly(2025, 4, 28), 4, 590.4f, 400f, "Garden Room", new DateOnly(2025, 4, 21), 563.6f },
                    { 15, 500f, 316f, 63.1f, new DateOnly(2025, 6, 23), 4, 815.7f, 500f, "Garden Room", new DateOnly(2025, 6, 16), 780.4f },
                    { 16, 600f, 462f, 77.1f, new DateOnly(2025, 8, 11), 4, 1062.4f, 600f, "Garden Room", new DateOnly(2025, 8, 4), 1010.7f },
                    { 17, 700f, 230f, 32.9f, new DateOnly(2025, 9, 29), 4, 930.3f, 700f, "Garden Room", new DateOnly(2025, 9, 22), 890.2f },
                    { 18, 1500f, 744f, 49.6f, new DateOnly(2025, 9, 28), 5, 2440.4f, 1500f, "Family Land V", new DateOnly(2025, 4, 21), 2175.6f },
                    { 19, 1600f, 1643f, 102.7f, new DateOnly(2025, 6, 23), 5, 3243.2f, 1600f, "Family Land V", new DateOnly(2025, 6, 16), 3147.7f },
                    { 20, 1700f, 2006f, 118f, new DateOnly(2025, 8, 11), 5, 3705.7f, 1700f, "Family Land V", new DateOnly(2025, 8, 4), 3597.4f },
                    { 21, 1800f, 1172f, 65.1f, new DateOnly(2025, 9, 29), 5, 2971.8f, 1800f, "Family Land V", new DateOnly(2025, 9, 22), 2869.3f },
                    { 22, 600f, 270f, 45f, new DateOnly(2025, 6, 23), 6, 870.2f, 600f, "Land View", new DateOnly(2025, 6, 16), 832.3f },
                    { 23, 700f, 314f, 44.9f, new DateOnly(2025, 8, 11), 6, 1014.4f, 700f, "Land View", new DateOnly(2025, 8, 4), 971.8f },
                    { 24, 800f, 106f, 13.3f, new DateOnly(2025, 9, 29), 6, 906.2f, 800f, "Land View", new DateOnly(2025, 9, 22), 866.6f },
                    { 25, 900f, 32f, 4.1f, new DateOnly(2025, 6, 23), 7, 798.6f, 766.9f, "Std Room", new DateOnly(2025, 6, 16), 766.9f },
                    { 26, 1000f, 40f, 4f, new DateOnly(2025, 8, 11), 7, 1037.6f, 998f, "Std Room", new DateOnly(2025, 8, 4), 998f },
                    { 27, 1100f, 26f, 5f, new DateOnly(2025, 9, 29), 7, 537f, 511.2f, "Std Room", new DateOnly(2025, 9, 22), 511.2f },
                    { 28, 900f, 113f, 17.4f, new DateOnly(2025, 4, 28), 8, 900f, 766.9f, "no-room-type", new DateOnly(2025, 4, 21), 766.9f },
                    { 29, 1000f, 2f, 0.2f, new DateOnly(2025, 6, 23), 8, 1000f, 998f, "no-room-type", new DateOnly(2025, 6, 16), 998f },
                    { 30, 1100f, 589f, 115.2f, new DateOnly(2025, 8, 11), 8, 1100f, 511.2f, "no-room-type", new DateOnly(2025, 8, 4), 511.2f },
                    { 31, 1100f, 589f, 115.2f, new DateOnly(2025, 9, 29), 8, 1100f, 511.2f, "no-room-type", new DateOnly(2025, 9, 22), 511.2f },
                    { 32, 900f, 113f, 17.4f, new DateOnly(2025, 4, 28), 9, 900f, 766.9f, "no-room-type", new DateOnly(2025, 4, 21), 766.9f },
                    { 33, 100f, 2f, 0.2f, new DateOnly(2025, 6, 23), 9, 1000f, 998f, "no-room-type", new DateOnly(2025, 6, 16), 998f },
                    { 34, 1100f, 589f, 115.2f, new DateOnly(2025, 8, 11), 9, 1100f, 511.2f, "no-room-type", new DateOnly(2025, 8, 4), 511.2f },
                    { 35, 1100f, 589f, 115.2f, new DateOnly(2025, 9, 9), 9, 1100f, 511.2f, "no-room-type", new DateOnly(2025, 9, 22), 511.2f },
                    { 36, 900f, 133f, 17.4f, new DateOnly(2025, 4, 28), 10, 900f, 766.9f, "no-room-type", new DateOnly(2025, 4, 21), 766.9f },
                    { 37, 1000f, 2f, 0.2f, new DateOnly(2025, 6, 23), 10, 1000f, 998f, "no-room-type", new DateOnly(2025, 6, 16), 998f },
                    { 38, 1100f, 589f, 115.2f, new DateOnly(2025, 8, 11), 10, 1100f, 511.2f, "no-room-type", new DateOnly(2025, 8, 4), 511.2f },
                    { 39, 1100f, 589f, 115.2f, new DateOnly(2025, 8, 11), 10, 1100f, 511.2f, "no-room-type", new DateOnly(2025, 8, 4), 511.2f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rates_HotelId",
                table: "Rates",
                column: "HotelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rates");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Hotels");
        }
    }
}
