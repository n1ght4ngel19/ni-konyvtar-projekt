using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public class Books        // public?
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Writer { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        public int Year_of_Publication { get; set; }

        public override string ToString()
        {
            return $"{Name}, by {Writer} from {Year_of_Publication}, published by {Publisher}, and ID of {Id}";
        }
    }
}
