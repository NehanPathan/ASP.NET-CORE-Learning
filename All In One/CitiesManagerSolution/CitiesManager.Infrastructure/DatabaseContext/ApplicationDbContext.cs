using CitiesManager.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace CitiesManager.Infrastructure.DatabaseContext

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public ApplicationDbContext()
        {
        }

        public virtual DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>().HasData(
                new City
                {
                    CityID = Guid.NewGuid(),
                    CityName = "New York"
                },
                new City
                {
                    CityID = Guid.NewGuid(),
                    CityName = "Los Angeles"
                },
                new City
                {
                    CityID = Guid.NewGuid(),
                    CityName = "Chicago"
                },
                new City
                {
                    CityID = Guid.NewGuid(),
                    CityName = "Houston"
                },
                new City
                {
                    CityID = Guid.NewGuid(),
                    CityName = "Phoenix"
                },
                new City
                {
                    CityID = Guid.NewGuid(),
                    CityName = "Philadelphia"
                },
                new City
                {
                    CityID = Guid.NewGuid(),
                    CityName = "San Antonio"
                },
                new City
                {
                    CityID = Guid.NewGuid(),
                    CityName = "San Diego"
                },
                new City
                {
                    CityID = Guid.NewGuid(),
                    CityName = "Dallas"
                },
                new City
                {
                    CityID = Guid.NewGuid(),
                    CityName = "San Jose"
                }
            );
        }

    }
}
