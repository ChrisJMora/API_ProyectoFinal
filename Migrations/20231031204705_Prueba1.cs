using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API_TouristBay.Migrations
{
    /// <inheritdoc />
    public partial class Prueba1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airline",
                columns: table => new
                {
                    IdAirline = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAirline = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airline", x => x.IdAirline);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    IdCity = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCity = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.IdCity);
                });

            migrationBuilder.CreateTable(
                name: "Flight",
                columns: table => new
                {
                    IdFlight = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AirlineFlight = table.Column<int>(type: "int", nullable: false),
                    OriginFlight = table.Column<int>(type: "int", nullable: false),
                    DestinationFlight = table.Column<int>(type: "int", nullable: false),
                    GateFlight = table.Column<int>(type: "int", nullable: false),
                    SeatsAvailFlight = table.Column<int>(type: "int", nullable: false),
                    PriceFlight = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flight", x => x.IdFlight);
                });

            migrationBuilder.CreateTable(
                name: "Passenger",
                columns: table => new
                {
                    IdPassenger = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstNamePassenger = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastNamePassenger = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenderPassenger = table.Column<bool>(type: "bit", nullable: false),
                    TypePassenger = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneAdult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAdult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdultYounger = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passenger", x => x.IdPassenger);
                });

            migrationBuilder.InsertData(
                table: "Airline",
                columns: new[] { "IdAirline", "NameAirline" },
                values: new object[,]
                {
                    { 1, "Latam Airlines" },
                    { 2, "Avianca Airlines" },
                    { 3, "Tame Airlines" },
                    { 4, "Copa Airlines" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "IdCity", "NameCity" },
                values: new object[,]
                {
                    { 1, "Quito" },
                    { 2, "Guayaquil" },
                    { 3, "Cuenca" },
                    { 4, "Manta" },
                    { 5, "Galápagos" },
                    { 6, "Esmeraldas" },
                    { 7, "Loja" }
                });

            migrationBuilder.InsertData(
                table: "Flight",
                columns: new[] { "IdFlight", "AirlineFlight", "DestinationFlight", "GateFlight", "OriginFlight", "PriceFlight", "SeatsAvailFlight" },
                values: new object[,]
                {
                    { "ABC123", 1, 2, 1, 1, 54.0, 30 },
                    { "DEF456", 2, 3, 2, 2, 42.0, 20 },
                    { "GHI789", 3, 4, 3, 3, 86.0, 10 }
                });

            migrationBuilder.InsertData(
                table: "Passenger",
                columns: new[] { "IdPassenger", "Discriminator", "FirstNamePassenger", "GenderPassenger", "LastNamePassenger", "TypePassenger" },
                values: new object[] { 1, "Passenger", "Christian", true, "Jacome", 1 });

            migrationBuilder.InsertData(
                table: "Passenger",
                columns: new[] { "IdPassenger", "Discriminator", "EmailAdult", "FirstNamePassenger", "GenderPassenger", "LastNamePassenger", "PhoneAdult", "TypePassenger" },
                values: new object[] { 2, "Adult", "mj@gmail.com", "Mario", true, "Jacome", "0992734743", 1 });

            migrationBuilder.InsertData(
                table: "Passenger",
                columns: new[] { "IdPassenger", "AdultYounger", "Discriminator", "FirstNamePassenger", "GenderPassenger", "LastNamePassenger", "TypePassenger" },
                values: new object[] { 3, -1, "Younger", "Sofia", false, "Jacome", 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Airline");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Flight");

            migrationBuilder.DropTable(
                name: "Passenger");
        }
    }
}
