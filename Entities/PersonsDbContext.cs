using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class PersonsDbContext : DbContext
    {
        public PersonsDbContext(DbContextOptions<PersonsDbContext> options) : base(options) 
        { 
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Person> Persons { get; set; }

        // Model binding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().ToTable("Countries");
            modelBuilder.Entity<Person>().ToTable("Persons");

            // Seed to Countries
            modelBuilder.Entity<Country>().HasData(
                new Country() { CountryID = Guid.NewGuid(), CountryName = "Norway" },
                new Country() { CountryID = Guid.NewGuid(), CountryName = "USA" },
                new Country() { CountryID = Guid.NewGuid(), CountryName = "Sweden" }
            );

            // Seed to Persons (PersonID is required)
            modelBuilder.Entity<Person>().HasData(
                new Person()
                {
                    PersonID = Guid.NewGuid(), // Ensure PersonID is set
                    PersonName = "Bøabøa",
                    Email = "afad@ad.com",
                    DateOfBirth = new DateTime(2010, 2, 1),
                    Gender = "Male",
                    ReceiveNewsLetters = false
                }
            );
        }
    }
}
