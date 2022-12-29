namespace LibraryAppNi.Data.Library
{
    public class Borrow
    {
        public int BorrowId { get; set; }
        public int MemberId { get; set; }
        public int BookId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime BorrowDeadline { get; set; } // TODO: Validate date
    }
}
