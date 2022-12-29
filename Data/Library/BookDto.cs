namespace LibraryAppNi.Data.Library
{
    public class BookDto
    {
        public int BookId { get; set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public String Publisher { get; set; }
        public int PublishYear { get; set; }
        public Boolean IsBorrowed { get; set; }
    }
}
