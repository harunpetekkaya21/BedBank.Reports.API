using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BedBankReports.API.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FileDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileExtension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MimeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    DiffEuro = table.Column<float>(type: "real", nullable: false, computedColumnSql: "[OtherToPrice] - [OurBestPrice]"),
                    DiffPercent = table.Column<float>(type: "real", nullable: false, computedColumnSql: "([OtherToPrice]/[OurBestPrice])-1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                columns: new[] { "Id", "CreatedDate", "HotelName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6622), "GRAND PARK LARA" },
                    { 2, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6626), "CONCORDIA CELES HOTEL" },
                    { 3, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6664), "ROYAL WINGS HOTEL" },
                    { 4, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6666), "HORUS PARADISE LUXURY RESORT" },
                    { 5, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6667), "ROYAL SEGINUS" },
                    { 6, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6669), "ALARCHA HOTELS" },
                    { 7, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6670), "NOXINN DELUXE HOTEL" },
                    { 8, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6671), "ADALYA ELITE LARA" },
                    { 9, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6672), "ALAN XAFIRA DELUXE RESORT" },
                    { 10, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6673), "SEVEN SEAS GRAVEL SELECT" }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "CreatedDate", "Date", "FinalCost", "FinalProfit", "FinalProfitPercent", "FinalSales", "Paxes", "ReservationCount", "RoomNights" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6869), new DateOnly(2024, 10, 1), 1500f, 1000f, 66.67f, 2500f, 50, 5, 50 },
                    { 2, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6873), new DateOnly(2024, 10, 2), 2000f, 500f, 25f, 2500f, 60, 6, 60 },
                    { 3, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6876), new DateOnly(2024, 10, 3), 1000f, 150f, 15f, 1500f, -1, -1, -1 },
                    { 4, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6879), new DateOnly(2024, 10, 4), 4500f, 400f, 8.99f, 4900f, -1, -1, -1 },
                    { 5, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6882), new DateOnly(2024, 10, 5), 985f, 65f, 6.6f, 1050f, -1, -1, -1 },
                    { 6, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6885), new DateOnly(2024, 10, 6), 900f, 600f, 66.67f, 1500f, -1, -1, -1 },
                    { 7, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6888), new DateOnly(2024, 10, 7), 900f, 250f, 38.89f, 1250f, -1, -1, -1 },
                    { 8, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6890), new DateOnly(2024, 10, 8), 900f, -150f, -16.67f, 750f, -1, -1, -1 },
                    { 9, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6893), new DateOnly(2024, 10, 9), 6800f, 1100f, 16.18f, 7900f, -1, -1, -1 },
                    { 10, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6895), new DateOnly(2024, 10, 10), 4900f, 1080f, 22.04f, 5980f, -1, -1, -1 },
                    { 11, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6898), new DateOnly(2024, 10, 11), 9600f, 1300f, 13.54f, 10900f, -1, -1, -1 },
                    { 12, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6900), new DateOnly(2024, 10, 12), 1500f, 1400f, 93.33f, 2900f, -1, -1, -1 },
                    { 13, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6904), new DateOnly(2024, 10, 13), 1900f, 840f, 44.21f, 2740f, -1, -1, -1 },
                    { 14, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6907), new DateOnly(2024, 10, 14), 3250f, 230f, 7.08f, 3480f, -1, -1, -1 },
                    { 15, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6909), new DateOnly(2024, 10, 15), 4900f, 450f, 9.18f, 5350f, -1, -1, -1 },
                    { 16, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6915), new DateOnly(2024, 10, 16), 1500f, 460f, 30.67f, 1960f, -1, -1, -1 },
                    { 17, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6918), new DateOnly(2024, 10, 17), 1400f, 90f, 6.43f, 1490f, -1, -1, -1 },
                    { 18, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6922), new DateOnly(2024, 10, 18), 3900f, 250f, 6.41f, 4150f, -1, -1, -1 },
                    { 19, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6924), new DateOnly(2024, 10, 19), 4900f, 140f, 2.86f, 5040f, -1, -1, -1 },
                    { 20, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6927), new DateOnly(2024, 10, 20), 1600f, -100f, -6.25f, 1500f, -1, -1, -1 },
                    { 21, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6930), new DateOnly(2024, 10, 21), 1460f, -70f, -4.79f, 1390f, -1, -1, -1 },
                    { 22, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6932), new DateOnly(2024, 10, 22), 1500f, 290f, 19.33f, 1790f, -1, -1, -1 },
                    { 23, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6935), new DateOnly(2024, 10, 23), 3500f, 150f, 4.29f, 3650f, -1, -1, -1 },
                    { 24, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6937), new DateOnly(2024, 10, 24), 1100f, 149f, 13.55f, 1249f, -1, -1, -1 },
                    { 25, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6940), new DateOnly(2024, 10, 25), 2600f, 190f, 7.31f, 2790f, -1, -1, -1 },
                    { 26, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6942), new DateOnly(2024, 10, 26), 2250f, 485f, 21.56f, 2735f, -1, -1, -1 },
                    { 27, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6945), new DateOnly(2024, 10, 27), 5600f, 380f, 6.79f, 5980f, -1, -1, -1 },
                    { 28, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6948), new DateOnly(2024, 10, 28), 5100f, 225f, 4.41f, 5325f, -1, -1, -1 },
                    { 29, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6952), new DateOnly(2024, 10, 29), 3100f, 850f, 27.42f, 3950f, -1, -1, -1 },
                    { 30, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6955), new DateOnly(2024, 10, 30), 3500f, 250f, 7.17f, 3750f, -1, -1, -1 },
                    { 31, new DateTime(2024, 11, 6, 6, 41, 51, 672, DateTimeKind.Utc).AddTicks(6957), new DateOnly(2024, 10, 31), 4550f, 420f, 9.23f, 4970f, -1, -1, -1 }
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
                name: "FileDatas");

            migrationBuilder.DropTable(
                name: "Rates");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Hotels");
        }
    }
}
