using System.ComponentModel.DataAnnotations;

namespace LibraryAppNi.Data.Model
{
    public class Book
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
