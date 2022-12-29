namespace LibraryAppNi.Data.Library
{
    public class Book
    {
        //public Book(String title, String author, String publisher, int publishYear)
        //{
        //    Title = title;
        //    Author = author;
        //    Publisher = publisher;
        //    PublishYear = publishYear;
        //}

        public int BookId { get; set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public String Publisher { get; set; }
        public int PublishYear { get; set; }
        public Boolean IsBorrowed { get; set; }
    }
}
