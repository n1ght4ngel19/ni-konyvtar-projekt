using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppNi.Shared.Model.BaseClass
{
    public class Member
    {
        public int MemberId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime BirthDate { get; set; } = DateTime.Today;
        [Required]
        public string Address { get; set; }
    }
}
