using Books_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Context
{
    public class UsersContext
    {
        public UsersContext()
        {
        }

        public DbSet<Users> Users { get; set; }
    }
}
