using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KonyvtarApp.Data.BorrowData;
using KonyvtarApp.Data.MemberData;

namespace KonyvtarApp.Data.BookData
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookID { get; set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public String Publisher { get; set; }
        public int PublishYear { get; set; }
        public Boolean IsBorrowed { get; set; }

        public virtual Borrow? BorrowData { get; set; }
    }
}
