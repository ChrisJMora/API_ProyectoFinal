
using Microsoft.EntityFrameworkCore;
using API_TouristBay.Models.Catalogues;
using API_TouristBay.Models.Passengers;

namespace API_TouristBay.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(
            DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<City> City { get; set; }

        public DbSet<Passenger> Passenger {  get; set; }

        public DbSet<PassengerType> PassengerType { get; set; }

        public DbSet<Adult> Adult {  get; set; }

        public DbSet<Younger> Younger { get; set; }

        public DbSet<Airline> Airline { get; set; }

        public DbSet<Flight> Flight { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                    new City(1,"Quito"),
                    new City(2,"Guayaquil"),
                    new City(3,"Cuenca"),
                    new City(4,"Manta"),
                    new City(5,"Galápagos"),
                    new City(6,"Esmeraldas"),
                    new City(7,"Loja")
                );

            modelBuilder.Entity<Passenger>().HasData(
                    new Passenger(1,"Christian","Jacome",true,new DateTime(2003,9,29),1)
                );

            modelBuilder.Entity<Adult>().HasData(
                    new Adult(2,"Mario","Jacome",true,new DateTime(1981,1,12),"0992734743","mj@gmail.com")
                );

            modelBuilder.Entity<Younger>().HasData(
                    new Younger(3,"Sofia","Jacome",false,new DateTime(2019,6,26),2,2)
                );

            modelBuilder.Entity<PassengerType>().HasData(
                    new PassengerType(1,"Adulto",true),
                    new PassengerType(2,"Niño",false),
                    new PassengerType(3,"Infante",false)
                );

            modelBuilder.Entity<Airline>().HasData(
                    new Airline(1,"Latam Airlines"),
                    new Airline(2,"Avianca Airlines"),
                    new Airline(3,"Tame Airlines"),
                    new Airline(4,"Copa Airlines")
                );

            modelBuilder.Entity<Flight>().Property(e => e.DepartureDateFlight).HasColumnType("date");
            modelBuilder.Entity<Flight>().Property(e => e.ArrivalDateFlight).HasColumnType("date");
            modelBuilder.Entity<Flight>().Property(e => e.DepartureTimeFlight).HasColumnType("time");
            modelBuilder.Entity<Flight>().Property(e => e.ArrivalTimeFlight).HasColumnType("time");

            modelBuilder.Entity<Flight>().HasData(
                    new Flight("ABC123", 1, 1, 2, 1, new DateTime(2023, 10, 29), new DateTime(2023, 10, 29), new TimeSpan(5, 10, 0),
                        new TimeSpan(6, 45, 0), 40, 20, 39.5, 50),
                    new Flight("ABC456", 2, 1, 2, 2, new DateTime(2023, 10, 29), new DateTime(2023, 10, 29), new TimeSpan(7, 30, 0),
                        new TimeSpan(8, 10, 0), 30, 10, 54, 77.5),
                    new Flight("DEF123", 3, 2, 3, 3, new DateTime(2023, 10, 29), new DateTime(2023, 10, 29), new TimeSpan(8, 30, 0),
                        new TimeSpan(9, 15, 0), 20, 5, 42, 38.99),
                    new Flight("GHI123", 4, 3, 4, 4, new DateTime(2023, 10, 29), new DateTime(2023, 10, 29), new TimeSpan(9, 30, 0),
                        new TimeSpan(10, 45, 0), 10, 3, 86, 115.99)
                );
        }
    }
}
