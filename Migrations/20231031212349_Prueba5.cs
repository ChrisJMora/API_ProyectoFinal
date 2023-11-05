using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_TouristBay.Migrations
{
    /// <inheritdoc />
    public partial class Prueba5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PassengerType",
                keyColumn: "IdPassangerType",
                keyValue: 2,
                column: "ViewPassengerType",
                value: false);

            migrationBuilder.UpdateData(
                table: "PassengerType",
                keyColumn: "IdPassangerType",
                keyValue: 3,
                column: "ViewPassengerType",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PassengerType",
                keyColumn: "IdPassangerType",
                keyValue: 2,
                column: "ViewPassengerType",
                value: true);

            migrationBuilder.UpdateData(
                table: "PassengerType",
                keyColumn: "IdPassangerType",
                keyValue: 3,
                column: "ViewPassengerType",
                value: true);
        }
    }
}
