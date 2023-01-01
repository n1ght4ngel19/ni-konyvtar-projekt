using LibraryAppNi.Shared.Model.DTO;

namespace LibraryAppNi.Shared.Repository.IRepository
{
    public interface IMemberRepository
    {
        public MemberDto Create(MemberDto memberDto);
        public MemberDto Update(MemberDto memberDto);
        public MemberDto Get(int id);
        public IEnumerable<MemberDto> GetAll();
        public int Delete(int id);
    }
}
