using LibraryAppNi.Data.Model;

namespace LibraryAppNi.Data.Repository.IRepository
{
    public interface IBookRepository
    {
        public BookDto Create(BookDto bookDto);
        public BookDto Update(BookDto bookDto);
        public int Delete(int bookId);
        public BookDto Get(int bookId);
        public IEnumerable<BookDto> GetAll();
        public BookDto MarkBorrowed(int bookId);
    }
}
