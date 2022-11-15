using System.ComponentModel.DataAnnotations;

namespace Books_Project.Models
{

    /*
     * - Könyvek adatai
        - Cím
        - Szerző
        - Kiadó
        - Leltári szám
        - Kiadás éve
     */
    public class Books
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; } = null;

        [Required]
        public string? Writer { get; set; } = null;

        [Required]
        public string? Publisher { get; set; } = null;

        [Required]
        public int Year_of_Publication { get; set; }

        public override string ToString()
        {
            return $"{Name}, by {Writer} from {Year_of_Publication}, published by {Publisher}, and ID of {Id}";
        }
    }
}
