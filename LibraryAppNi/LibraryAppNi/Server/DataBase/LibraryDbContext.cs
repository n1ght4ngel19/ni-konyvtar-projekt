using LibraryAppNi.Shared.Model.BaseClass;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LibraryAppNi.Server.DataBase
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) {
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
    }
}
