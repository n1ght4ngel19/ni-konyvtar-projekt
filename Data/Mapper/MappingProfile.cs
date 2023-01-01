using AutoMapper;
using LibraryAppNi.Data.Model;

namespace LibraryAppNi.Data.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            _ = CreateMap<Book, BookDto>().ReverseMap();
            _ = CreateMap<Member, MemberDto>().ReverseMap();
            _ = CreateMap<Borrow, BorrowDto>().ReverseMap();
        }
    }
}
