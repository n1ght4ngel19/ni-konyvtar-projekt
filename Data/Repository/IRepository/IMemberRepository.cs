using LibraryAppNi.Data.Model;

namespace LibraryAppNi.Data.Repository.IRepository
{
    public interface IMemberRepository
    {
        public MemberDto Create(MemberDto memberDto);
        public MemberDto Update(MemberDto memberDto);
        public int Delete(int memberId);
        public MemberDto Get(int memberId);
        public IEnumerable<MemberDto> GetAll();
        public bool ValidateName(string name);
    }
}
