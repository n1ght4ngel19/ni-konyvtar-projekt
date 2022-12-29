using System.ComponentModel.DataAnnotations;
using KonyvtarApp.Data.BookData;
using KonyvtarApp.Data.MemberData;

namespace KonyvtarApp.Data.BorrowData
{
    public class Borrow
    {
        public int BorrowID { get; set; }
        public int MemberID { get; set; }
        public int BookID { get; set; }
		public DateTime BorrowDate { get; set; }
		public DateTime BorrowDeadline { get; set; } // TODO: Validate date

		public virtual Member Borrower { get; set; }
        public virtual Book BorrowedBook { get; set; }

    }
}
