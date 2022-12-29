using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KonyvtarApp.Data.MemberData;

namespace KonyvtarApp.Data.DAL
{
    public class LibraryAppContext : DbContext
    {
        public LibraryAppContext (DbContextOptions<LibraryAppContext> options)
            : base(options)
        {
        }

        public DbSet<KonyvtarApp.Data.MemberData.Member> Member { get; set; } = default!;
    }
}
