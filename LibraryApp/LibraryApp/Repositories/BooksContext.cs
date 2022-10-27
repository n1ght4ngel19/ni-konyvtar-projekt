using Books_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace LibraryApp.Repositories
{
    public class BooksContext: DbContext
    {
        public BooksContext()
        {
        }

        public BooksContext([NotNull] DbContextOptions options) :base(options)
        {
        }

        public DbSet<Books> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\mssqllocaldb;Database=ServerDb;Integrated Security=True;");
        }
    }
}
