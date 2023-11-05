using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_TouristBay.Migrations
{
    /// <inheritdoc />
    public partial class Prueba2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Passenger",
                keyColumn: "IdPassenger",
                keyValue: 3,
                column: "AdultYounger",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Passenger",
                keyColumn: "IdPassenger",
                keyValue: 3,
                column: "AdultYounger",
                value: -1);
        }
    }
}
