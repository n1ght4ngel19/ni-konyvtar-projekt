namespace LibraryAppNi.Data.Library
{
    public class MemberDto
    {
        public int MemberId { get; set; }
        public string Name { get; set; } // TODO: Validate name
        public DateTime BirthDate { get; set; }
        public String Address { get; set; }
    }
}
