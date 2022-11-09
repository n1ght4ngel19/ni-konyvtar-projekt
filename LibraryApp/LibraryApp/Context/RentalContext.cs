using Books_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Context
{
    public class RentalContext
    {
        public RentalContext()
        {
        }

        public DbSet<Rental> Rentals { get; set; }
    }
}
