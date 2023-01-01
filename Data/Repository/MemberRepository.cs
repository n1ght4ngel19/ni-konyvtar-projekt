using AutoMapper;
using LibraryAppNi.Data.Database;
using LibraryAppNi.Data.Model;
using LibraryAppNi.Data.Repository.IRepository;

namespace LibraryAppNi.Data.Repository
{
    public class MemberRepository : IMemberRepository
    {
        private readonly LibraryDbContext _db;
        private readonly IMapper _mapper;

        public MemberRepository(LibraryDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public MemberDto Create(MemberDto memberDto)
        {
            var member = _mapper.Map<MemberDto, Member>(memberDto);

            _ = _db.Add(member);
            _ = _db.SaveChanges();

            return _mapper.Map<Member, MemberDto>(member);
        }

        public int Delete(int bookId)
        {
            var member = _db.Members.FirstOrDefault(u => u.MemberId == bookId);

            if (member != null)
            {
                _ = _db.Members.Remove(member);

                return _db.SaveChanges();
            }

            return 0;
        }

        public MemberDto Get(int memberId)
        {
            var member = _db.Members.FirstOrDefault(u => u.MemberId == memberId);

            if (member != null)
            {
                return _mapper.Map<Member, MemberDto>(member);
            }

            return new MemberDto();
        }

        public IEnumerable<MemberDto> GetAll()
        {
            return _mapper.Map<IEnumerable<Member>, IEnumerable<MemberDto>>(_db.Members);
        }

        public MemberDto Update(MemberDto memberDto)
        {
            var member = _db.Members.FirstOrDefault(u => u.MemberId == memberDto.MemberId);

            if (member != null)
            {
                member.Name = memberDto.Name;
                member.BirthDate = memberDto.BirthDate;
                member.Address = memberDto.Address;

                _ = _db.Members.Update(member);
                _ = _db.SaveChanges();

                return _mapper.Map<Member, MemberDto>(member);
            }

            return memberDto;
        }

        public bool ValidateName(string name)
        {
            if (name.Equals(null) || name.Equals(""))
            {
                return false;
            }

            if (name.IndexOfAny("'+!%/=(),[]ĐđłŁ$÷×¸¨˝´˙`˛°˘^ˇ~.?:-_<>#&@{} ".ToCharArray()) != -1)
            {
                return false;
            }


            return true;
        }
    }
}
