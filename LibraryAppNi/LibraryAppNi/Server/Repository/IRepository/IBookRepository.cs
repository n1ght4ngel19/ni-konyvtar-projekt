using LibraryAppNi.Shared.Model.DTO;

namespace LibraryAppNi.Server.Repository.IRepository
{
    public interface IBookRepository
    {
        public BookDto Create(BookDto bookDto);
        public BookDto Update(BookDto bookDto);
        public BookDto Get(int id);
        public IEnumerable<BookDto> GetAll();
        public int Delete(int id);
    }
}
