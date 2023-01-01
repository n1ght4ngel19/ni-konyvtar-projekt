using System.ComponentModel.DataAnnotations;

namespace LibraryAppNi.Data.Model
{
    public class BorrowDto
    {
        [Required]
        public int BorrowId { get; set; }
        [Required]
        public int MemberId { get; set; }
        [Required]
        public int BookId { get; set; }
        [Required]
        public DateTime BorrowDate { get; set; } = DateTime.Today;
        [Required]
        public DateTime BorrowDeadline { get; set; } = DateTime.Today;
    }
}
