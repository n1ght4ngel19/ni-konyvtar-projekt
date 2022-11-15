using Books_Project.Models;
using LibraryApp.Context;

namespace LibraryApp.Repositories
{
    public class RentalRepository
    {


        /// <summary>
        /// Method to get all Rental objects.
        /// </summary>
        /// <returns>Returns all Rentals.</returns>
        public static IList<Rental> GetRentals()
        {
            using (var database = new LibraryContext())
            {
                var rent = database.Rentals.ToList();

                return rent;
            }
        }

        /// <summary>
        /// Returns the Rental of the corresponding ID.
        /// </summary>
        /// <param name="id">ID of the Rental we want to get.</param>
        /// <returns>The Rental which's ID we gave</returns>
        public static Rental? GetRental(int id)
        {
            using (var database = new LibraryContext())
            {
                var rent = database.Rentals.Where(p => p.Id == id).FirstOrDefault();
                return rent;
            }
        }

        /// <summary>
        /// Adds the given Rental to the database.
        /// </summary>
        /// <param name="rent">The Rental object we want to add to the database</param>
        public static void AddRental(Rental rent)
        {
            using (var database = new LibraryContext())
            {
                database.Rentals.Add(rent);

                database.SaveChanges();
            }
        }

        public static bool UpdateRental(Rental rent, int id)
        {
            using (var database = new LibraryContext())
            {
                var dbRental = database.Rentals.Where(p => p.Id == id).FirstOrDefault();
                if (dbRental != null)
                {
                    database.Rentals.Update(rent);

                    database.SaveChanges();

                    return true;

                }
                return false;
            }
        }

        /// <summary>
        /// Deletes the given Rental from the database
        /// </summary>
        /// <param name="rent">Rental to be deleted from the database</param>
        public static void DeleteRental(Rental rent)
        {
            using (var database = new LibraryContext())
            {
                database.Rentals.Remove(rent);

                database.SaveChanges();
            }
        }
    }
}
