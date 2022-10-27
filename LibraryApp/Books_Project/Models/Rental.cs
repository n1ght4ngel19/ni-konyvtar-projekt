using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public long Id { get; set; } 

        public int UserId { get; set; }      // User Id

        public int BookId { get; set; }     // Books Id

        public DateTime rentalStart { get; set; }

        public DateTime rentalEnd { get; set; }
    }
}
