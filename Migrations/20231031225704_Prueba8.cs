using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_TouristBay.Migrations
{
    /// <inheritdoc />
    public partial class Prueba8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ArrivalDateFlight",
                table: "Flight",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "ArrivalTimeFlight",
                table: "Flight",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "DepartureTimeFlight",
                table: "Flight",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "IdFlight",
                keyValue: "ABC123",
                columns: new[] { "ArrivalDateFlight", "ArrivalTimeFlight", "DepartureTimeFlight" },
                values: new object[] { new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 10, 0, 0), new TimeSpan(0, 7, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "IdFlight",
                keyValue: "DEF456",
                columns: new[] { "ArrivalDateFlight", "ArrivalTimeFlight", "DepartureTimeFlight" },
                values: new object[] { new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 15, 0, 0), new TimeSpan(0, 8, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "IdFlight",
                keyValue: "GHI789",
                columns: new[] { "ArrivalDateFlight", "ArrivalTimeFlight", "DepartureTimeFlight" },
                values: new object[] { new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 45, 0, 0), new TimeSpan(0, 9, 30, 0, 0) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArrivalDateFlight",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "ArrivalTimeFlight",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "DepartureTimeFlight",
                table: "Flight");
        }
    }
}
