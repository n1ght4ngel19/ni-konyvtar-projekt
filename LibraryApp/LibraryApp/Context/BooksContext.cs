using Books_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Context
{
    public class BooksContext : DbContext
    {
        public BooksContext()
        {
        }

        // public BooksContext([NotNull] DbContextOptions options) :base(options){}

        public DbSet<Books> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\mssqllocaldb;Database=ServerDb;Integrated Security=True;");
        }
    }
}
