using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API_TouristBay.Migrations
{
    /// <inheritdoc />
    public partial class Prueba4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PassengerType",
                columns: table => new
                {
                    IdPassangerType = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamePassengerType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViewPassengerType = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassengerType", x => x.IdPassangerType);
                });

            migrationBuilder.InsertData(
                table: "PassengerType",
                columns: new[] { "IdPassangerType", "NamePassengerType", "ViewPassengerType" },
                values: new object[,]
                {
                    { 1, "Adulto", true },
                    { 2, "Niño", true },
                    { 3, "Infante", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PassengerType");
        }
    }
}
