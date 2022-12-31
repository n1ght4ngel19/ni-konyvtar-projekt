using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppNi.Shared.Model.Dto
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
        public Boolean IsBorrowed { get; set; } = false;
    }
}
