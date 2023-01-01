using System.ComponentModel.DataAnnotations;

namespace LibraryAppNi.Data.Model
{
    public class Borrow
    {
        public int BorrowId { get; set; }
        [Required]
        public int MemberId { get; set; }
        [Required]
        public int BookId { get; set; }
        [Required]
        public DateTime BorrowDate { get; set; }
        [Required]
        public DateTime BorrowDeadline { get; set; }
    }
}
