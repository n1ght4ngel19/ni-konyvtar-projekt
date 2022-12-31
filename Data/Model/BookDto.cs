using System.ComponentModel.DataAnnotations;

namespace LibraryAppNi.Data.Library
{
    public class BookDto
    {
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public int PublishYear { get; set; }
        [Required]
        public bool IsBorrowed { get; set; }
    }
}
