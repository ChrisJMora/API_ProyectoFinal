using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_TouristBay.Migrations
{
    /// <inheritdoc />
    public partial class Prueba15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Vuelo",
                table: "Passenger",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Passenger",
                keyColumn: "IdPassenger",
                keyValue: 1,
                column: "Vuelo",
                value: "A123");

            migrationBuilder.UpdateData(
                table: "Passenger",
                keyColumn: "IdPassenger",
                keyValue: 2,
                column: "Vuelo",
                value: "A456");

            migrationBuilder.UpdateData(
                table: "Passenger",
                keyColumn: "IdPassenger",
                keyValue: 3,
                column: "Vuelo",
                value: "A123");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Vuelo",
                table: "Passenger");
        }
    }
}
