using System.ComponentModel.DataAnnotations;
using KonyvtarApp.Data.BookData;
using KonyvtarApp.Data.BorrowData;

namespace KonyvtarApp.Data.MemberData
{
    public class Member
    {
        public int MemberID { get; set; }
        public string Name { get; set; } // TODO: Validate name
        public DateTime BirthDate { get; set; }
        public String Address { get; set; }

        public virtual List<Borrow> Borrows { get; set; }
    }
}
