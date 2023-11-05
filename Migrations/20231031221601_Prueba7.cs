using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_TouristBay.Migrations
{
    /// <inheritdoc />
    public partial class Prueba7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DepartureDateFlight",
                table: "Flight",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "IdFlight",
                keyValue: "ABC123",
                column: "DepartureDateFlight",
                value: new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "IdFlight",
                keyValue: "DEF456",
                column: "DepartureDateFlight",
                value: new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "IdFlight",
                keyValue: "GHI789",
                column: "DepartureDateFlight",
                value: new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartureDateFlight",
                table: "Flight");
        }
    }
}
