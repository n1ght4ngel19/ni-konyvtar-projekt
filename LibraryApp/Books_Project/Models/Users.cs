using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public long Id { get; set; }         // Olvasószám?

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}
