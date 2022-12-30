using System.ComponentModel.DataAnnotations;

namespace LibraryAppNi.Data.Library
{
    public class BookDto
    {
        public int BookId { get; set; }
        [Required]
        public String Title { get; set; }
        [Required]
        public String Author { get; set; }
        [Required]
        public String Publisher { get; set; }
        [Required]
        public int PublishYear { get; set; }
        [Required]
        public Boolean IsBorrowed { get; set; }
    }
}
