using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_TouristBay.Migrations
{
    /// <inheritdoc />
    public partial class Prueba12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "PrefPriceFlight",
                table: "Flight",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "PrefSeatsAvailFlight",
                table: "Flight",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "IdFlight",
                keyValue: "ABC123",
                columns: new[] { "PrefPriceFlight", "PrefSeatsAvailFlight" },
                values: new object[] { 50.0, 20 });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "IdFlight",
                keyValue: "ABC456",
                columns: new[] { "PrefPriceFlight", "PrefSeatsAvailFlight" },
                values: new object[] { 77.5, 10 });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "IdFlight",
                keyValue: "DEF123",
                columns: new[] { "PrefPriceFlight", "PrefSeatsAvailFlight" },
                values: new object[] { 38.990000000000002, 5 });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "IdFlight",
                keyValue: "GHI123",
                columns: new[] { "PrefPriceFlight", "PrefSeatsAvailFlight" },
                values: new object[] { 115.98999999999999, 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrefPriceFlight",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "PrefSeatsAvailFlight",
                table: "Flight");
        }
    }
}
