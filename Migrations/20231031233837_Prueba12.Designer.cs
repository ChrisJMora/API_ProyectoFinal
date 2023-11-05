﻿// <auto-generated />
using System;
using API_TouristBay.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_TouristBay.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20231031233837_Prueba12")]
    partial class Prueba12
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API_TouristBay.Models.Catalogues.Airline", b =>
                {
                    b.Property<int>("IdAirline")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAirline"));

                    b.Property<string>("NameAirline")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAirline");

                    b.ToTable("Airline");

                    b.HasData(
                        new
                        {
                            IdAirline = 1,
                            NameAirline = "Latam Airlines"
                        },
                        new
                        {
                            IdAirline = 2,
                            NameAirline = "Avianca Airlines"
                        },
                        new
                        {
                            IdAirline = 3,
                            NameAirline = "Tame Airlines"
                        },
                        new
                        {
                            IdAirline = 4,
                            NameAirline = "Copa Airlines"
                        });
                });

            modelBuilder.Entity("API_TouristBay.Models.Catalogues.City", b =>
                {
                    b.Property<int>("IdCity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCity"));

                    b.Property<string>("NameCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCity");

                    b.ToTable("City");

                    b.HasData(
                        new
                        {
                            IdCity = 1,
                            NameCity = "Quito"
                        },
                        new
                        {
                            IdCity = 2,
                            NameCity = "Guayaquil"
                        },
                        new
                        {
                            IdCity = 3,
                            NameCity = "Cuenca"
                        },
                        new
                        {
                            IdCity = 4,
                            NameCity = "Manta"
                        },
                        new
                        {
                            IdCity = 5,
                            NameCity = "Galápagos"
                        },
                        new
                        {
                            IdCity = 6,
                            NameCity = "Esmeraldas"
                        },
                        new
                        {
                            IdCity = 7,
                            NameCity = "Loja"
                        });
                });

            modelBuilder.Entity("API_TouristBay.Models.Catalogues.Flight", b =>
                {
                    b.Property<string>("IdFlight")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AirlineFlight")
                        .HasColumnType("int");

                    b.Property<DateTime>("ArrivalDateFlight")
                        .HasColumnType("date");

                    b.Property<TimeSpan>("ArrivalTimeFlight")
                        .HasColumnType("time");

                    b.Property<DateTime>("DepartureDateFlight")
                        .HasColumnType("date");

                    b.Property<TimeSpan>("DepartureTimeFlight")
                        .HasColumnType("time");

                    b.Property<int>("DestinationFlight")
                        .HasColumnType("int");

                    b.Property<int>("GateFlight")
                        .HasColumnType("int");

                    b.Property<int>("OriginFlight")
                        .HasColumnType("int");

                    b.Property<double>("PrefPriceFlight")
                        .HasColumnType("float");

                    b.Property<int>("PrefSeatsAvailFlight")
                        .HasColumnType("int");

                    b.Property<double>("PriceFlight")
                        .HasColumnType("float");

                    b.Property<int>("SeatsAvailFlight")
                        .HasColumnType("int");

                    b.HasKey("IdFlight");

                    b.ToTable("Flight");

                    b.HasData(
                        new
                        {
                            IdFlight = "ABC123",
                            AirlineFlight = 1,
                            ArrivalDateFlight = new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ArrivalTimeFlight = new TimeSpan(0, 6, 45, 0, 0),
                            DepartureDateFlight = new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartureTimeFlight = new TimeSpan(0, 5, 10, 0, 0),
                            DestinationFlight = 2,
                            GateFlight = 1,
                            OriginFlight = 1,
                            PrefPriceFlight = 50.0,
                            PrefSeatsAvailFlight = 20,
                            PriceFlight = 39.5,
                            SeatsAvailFlight = 40
                        },
                        new
                        {
                            IdFlight = "ABC456",
                            AirlineFlight = 2,
                            ArrivalDateFlight = new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ArrivalTimeFlight = new TimeSpan(0, 8, 10, 0, 0),
                            DepartureDateFlight = new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartureTimeFlight = new TimeSpan(0, 7, 30, 0, 0),
                            DestinationFlight = 2,
                            GateFlight = 2,
                            OriginFlight = 1,
                            PrefPriceFlight = 77.5,
                            PrefSeatsAvailFlight = 10,
                            PriceFlight = 54.0,
                            SeatsAvailFlight = 30
                        },
                        new
                        {
                            IdFlight = "DEF123",
                            AirlineFlight = 3,
                            ArrivalDateFlight = new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ArrivalTimeFlight = new TimeSpan(0, 9, 15, 0, 0),
                            DepartureDateFlight = new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartureTimeFlight = new TimeSpan(0, 8, 30, 0, 0),
                            DestinationFlight = 3,
                            GateFlight = 3,
                            OriginFlight = 2,
                            PrefPriceFlight = 38.990000000000002,
                            PrefSeatsAvailFlight = 5,
                            PriceFlight = 42.0,
                            SeatsAvailFlight = 20
                        },
                        new
                        {
                            IdFlight = "GHI123",
                            AirlineFlight = 4,
                            ArrivalDateFlight = new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ArrivalTimeFlight = new TimeSpan(0, 10, 45, 0, 0),
                            DepartureDateFlight = new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartureTimeFlight = new TimeSpan(0, 9, 30, 0, 0),
                            DestinationFlight = 4,
                            GateFlight = 4,
                            OriginFlight = 3,
                            PrefPriceFlight = 115.98999999999999,
                            PrefSeatsAvailFlight = 3,
                            PriceFlight = 86.0,
                            SeatsAvailFlight = 10
                        });
                });

            modelBuilder.Entity("API_TouristBay.Models.Passengers.Passenger", b =>
                {
                    b.Property<int>("IdPassenger")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPassenger"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstNamePassenger")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GenderPassenger")
                        .HasColumnType("bit");

                    b.Property<string>("LastNamePassenger")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypePassenger")
                        .HasColumnType("int");

                    b.HasKey("IdPassenger");

                    b.ToTable("Passenger");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Passenger");

                    b.UseTphMappingStrategy();

                    b.HasData(
                        new
                        {
                            IdPassenger = 1,
                            FirstNamePassenger = "Christian",
                            GenderPassenger = true,
                            LastNamePassenger = "Jacome",
                            TypePassenger = 1
                        });
                });

            modelBuilder.Entity("API_TouristBay.Models.Passengers.PassengerType", b =>
                {
                    b.Property<int>("IdPassangerType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPassangerType"));

                    b.Property<string>("NamePassengerType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ViewPassengerType")
                        .HasColumnType("bit");

                    b.HasKey("IdPassangerType");

                    b.ToTable("PassengerType");

                    b.HasData(
                        new
                        {
                            IdPassangerType = 1,
                            NamePassengerType = "Adulto",
                            ViewPassengerType = true
                        },
                        new
                        {
                            IdPassangerType = 2,
                            NamePassengerType = "Niño",
                            ViewPassengerType = false
                        },
                        new
                        {
                            IdPassangerType = 3,
                            NamePassengerType = "Infante",
                            ViewPassengerType = false
                        });
                });

            modelBuilder.Entity("API_TouristBay.Models.Passengers.Adult", b =>
                {
                    b.HasBaseType("API_TouristBay.Models.Passengers.Passenger");

                    b.Property<string>("EmailAdult")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneAdult")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Adult");

                    b.HasData(
                        new
                        {
                            IdPassenger = 2,
                            FirstNamePassenger = "Mario",
                            GenderPassenger = true,
                            LastNamePassenger = "Jacome",
                            TypePassenger = 1,
                            EmailAdult = "mj@gmail.com",
                            PhoneAdult = "0992734743"
                        });
                });

            modelBuilder.Entity("API_TouristBay.Models.Passengers.Younger", b =>
                {
                    b.HasBaseType("API_TouristBay.Models.Passengers.Passenger");

                    b.Property<int>("AdultYounger")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Younger");

                    b.HasData(
                        new
                        {
                            IdPassenger = 3,
                            FirstNamePassenger = "Sofia",
                            GenderPassenger = false,
                            LastNamePassenger = "Jacome",
                            TypePassenger = 2,
                            AdultYounger = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
