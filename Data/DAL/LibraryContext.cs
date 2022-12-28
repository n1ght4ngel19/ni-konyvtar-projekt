using KonyvtarApp.Data.BookData;
using KonyvtarApp.Data.BorrowData;
using KonyvtarApp.Data.MemberData;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace KonyvtarApp.Data.DAL
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("LibraryContext")
        {
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrow> Borrows { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}