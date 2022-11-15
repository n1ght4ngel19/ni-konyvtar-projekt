using Books_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Context
{
    public class LibraryContext : DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public LibraryContext()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
        }

        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\mssqllocaldb;Database=ServerDb;Integrated Security=True;");
        }
    }
}
