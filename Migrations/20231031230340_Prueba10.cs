using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API_TouristBay.Migrations
{
    /// <inheritdoc />
    public partial class Prueba10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Flight",
                keyColumn: "IdFlight",
                keyValue: "DEF456");

            migrationBuilder.DeleteData(
                table: "Flight",
                keyColumn: "IdFlight",
                keyValue: "GHI789");

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "IdFlight",
                keyValue: "ABC123",
                columns: new[] { "ArrivalTimeFlight", "DepartureTimeFlight", "PriceFlight", "SeatsAvailFlight" },
                values: new object[] { new TimeSpan(0, 6, 45, 0, 0), new TimeSpan(0, 5, 10, 0, 0), 39.5, 40 });

            migrationBuilder.InsertData(
                table: "Flight",
                columns: new[] { "IdFlight", "AirlineFlight", "ArrivalDateFlight", "ArrivalTimeFlight", "DepartureDateFlight", "DepartureTimeFlight", "DestinationFlight", "GateFlight", "OriginFlight", "PriceFlight", "SeatsAvailFlight" },
                values: new object[,]
                {
                    { "ABC456", 2, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 10, 0, 0), new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 30, 0, 0), 2, 2, 1, 54.0, 30 },
                    { "DEF123", 3, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 15, 0, 0), new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 30, 0, 0), 3, 3, 2, 42.0, 20 },
                    { "GHI123", 4, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 45, 0, 0), new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 30, 0, 0), 4, 4, 3, 86.0, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Flight",
                keyColumn: "IdFlight",
                keyValue: "ABC456");

            migrationBuilder.DeleteData(
                table: "Flight",
                keyColumn: "IdFlight",
                keyValue: "DEF123");

            migrationBuilder.DeleteData(
                table: "Flight",
                keyColumn: "IdFlight",
                keyValue: "GHI123");

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "IdFlight",
                keyValue: "ABC123",
                columns: new[] { "ArrivalTimeFlight", "DepartureTimeFlight", "PriceFlight", "SeatsAvailFlight" },
                values: new object[] { new TimeSpan(0, 8, 10, 0, 0), new TimeSpan(0, 7, 30, 0, 0), 54.0, 30 });

            migrationBuilder.InsertData(
                table: "Flight",
                columns: new[] { "IdFlight", "AirlineFlight", "ArrivalDateFlight", "ArrivalTimeFlight", "DepartureDateFlight", "DepartureTimeFlight", "DestinationFlight", "GateFlight", "OriginFlight", "PriceFlight", "SeatsAvailFlight" },
                values: new object[,]
                {
                    { "DEF456", 2, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 15, 0, 0), new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 30, 0, 0), 3, 2, 2, 42.0, 20 },
                    { "GHI789", 3, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 45, 0, 0), new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 30, 0, 0), 4, 3, 3, 86.0, 10 }
                });
        }
    }
}
