using Books_Project.Models;
using LibraryApp.Context;

namespace LibraryApp.Repositories
{
    public class UsersRepository
    {

        /// <summary>
        /// Method to get all User objects.
        /// </summary>
        /// <returns>Returns all Users.</returns>
        public static IList<Users> GetUsers()
        {
            using (var database = new LibraryContext())
            {
                var user = database.Users.ToList();

                return user;
            }
        }

        /// <summary>
        /// Returns the User of the corresponding ID.
        /// </summary>
        /// <param name="id">ID of the Rental we want to get.</param>
        /// <returns>The User which's ID we gave</returns>
        public static Users? GetUser(int id)
        {
            using (var database = new LibraryContext())
            {
                var user = database.Users.Where(p => p.Id == id).FirstOrDefault();

                return user;
            }
        }

        /// <summary>
        /// Adds the given User to the database.
        /// </summary>
        /// <param name="user">The User object we want to add to the database</param>
        public static void AddUser(Users user)
        {
            using (var database = new LibraryContext())
            {
                database.Users.Add(user);

                database.SaveChanges();
            }
        }

        public static bool UpdateUser(Users user, int id)
        {
            using (var database = new LibraryContext())
            {
                var dbUser = database.Users.Where(p => p.Id == id).FirstOrDefault();
                if (dbUser != null)
                {
                    database.Users.Update(user);

                    database.SaveChanges();

                    return true;

                }
                return false;
            }
        }

        /// <summary>
        /// Deletes the given User from the database
        /// </summary>
        /// <param name="user">User to be deleted from the database</param>
        public static void DeleteUser(Users user)
        {
            using (var database = new LibraryContext())
            {
                database.Users.Remove(user);

                database.SaveChanges();
            }
        }
    }
}
