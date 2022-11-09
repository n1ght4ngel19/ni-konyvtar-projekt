using System.ComponentModel.DataAnnotations;

namespace Books_Project.Models
{

    /*
     * - Könyvtár tagok adatai
        - Név
            - Nem lehet: üres, whitespace, különleges karakterek szűrése pl !?_-:;#
        - Lakcím
        - Olvasószám
        - Születési dátum
     */
    public class Users
    {
        [Key]
        public long Id { get; set; }         // Olvasószám?

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}
