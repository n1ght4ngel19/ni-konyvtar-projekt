using System.ComponentModel.DataAnnotations;

namespace LibraryAppNi.Data.Library
{
    public class Member
    {
        public int MemberId { get; set; }
        [Required]
        public string Name { get; set; } // TODO: Validate name
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public String Address { get; set; }
    }
}
