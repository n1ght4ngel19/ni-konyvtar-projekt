using AutoMapper;
using LibraryAppNi.Data.Library;

namespace LibraryAppNi.Data.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        { 
            CreateMap<Book, BookDto>().ReverseMap();
			CreateMap<Member, MemberDto>().ReverseMap();
			CreateMap<Borrow, BorrowDto>().ReverseMap();
		}
    }
}
