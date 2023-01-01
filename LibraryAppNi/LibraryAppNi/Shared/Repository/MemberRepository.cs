using AutoMapper;
using LibraryAppNi.Shared.DataBase;
using LibraryAppNi.Shared.Model.BaseClass;
using LibraryAppNi.Shared.Model.DTO;
using LibraryAppNi.Shared.Repository.IRepository;

namespace LibraryAppNi.Shared.Repository
{
    public class MemberRepository : IMemberRepository
    {
        private readonly LibraryDbContext _db;
        private readonly IMapper _mapper;

        public MemberDto Create(MemberDto MemberDto)
        {
            var Member = _mapper.Map<MemberDto, MemberDto>(MemberDto);

            _db.Add(Member);
            _db.SaveChangesAsync();

            return _mapper.Map<MemberDto, MemberDto>(Member);
        }

        public int Delete(int id)
        {
            var member = _db.Members.FirstOrDefault(member => member.MemberId == id);

            if (member != null)
            {
                _db.Remove(member);

                return _db.SaveChanges();
            }

            return 0;
        }

        public MemberDto Get(int id)
        {
            var member = _db.Members.FirstOrDefault(member => member.MemberId == id);

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
            var member = _db.Members.FirstOrDefault(Member => Member.MemberId == memberDto.MemberId);

            if (member != null)
            {
                member.Name = memberDto.Name;
                member.BirthDate = memberDto.BirthDate;
                member.Address = memberDto.Address;

                _db.Members.Update(member);
                _db.SaveChanges();

                return _mapper.Map<Member, MemberDto>(member);
            }

            return memberDto;
        }
    }
}
