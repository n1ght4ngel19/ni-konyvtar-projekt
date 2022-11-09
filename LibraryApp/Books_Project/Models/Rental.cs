using System.ComponentModel.DataAnnotations;

namespace Books_Project.Models
{
    /*
    
    - Kölcsönzések adatai
        - Olvasószám (Tag)
        - Leltári szám (Könyv)
        - Kölcsönzés ideje
        - Visszahozás határideje
            - Csak későbbi dátum lehet mint a kölcsönzés ideje (DateTime típus használata)
     */
    public class Rental
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int BookId { get; set; }

        public DateTime rentalStart { get; set; }

        public DateTime rentalEnd { get; set; }
    }
}
