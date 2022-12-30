using System.ComponentModel.DataAnnotations;

namespace LibraryAppNi.Data.Library
{
    public class MemberDto
    {
        public int MemberId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
		public string Address { get; set; }
    }
}
