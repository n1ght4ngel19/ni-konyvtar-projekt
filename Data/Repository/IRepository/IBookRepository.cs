using LibraryAppNi.Data.Library;

namespace LibraryAppNi.Data.Repository.IRepository
{
    public interface IBookRepository
    {
        public BookDto Create(BookDto bookDto);
        public BookDto Update(BookDto bookDto);
        public int Delete(int bookId);
        public BookDto Get(int bookId);
        public IEnumerable<BookDto> GetAll();
    }
}
