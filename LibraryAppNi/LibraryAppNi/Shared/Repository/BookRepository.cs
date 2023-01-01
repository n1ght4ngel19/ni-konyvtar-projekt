using AutoMapper;
using LibraryAppNi.Shared.DataBase;
using LibraryAppNi.Shared.Model.BaseClass;
using LibraryAppNi.Shared.Model.DTO;
using LibraryAppNi.Shared.Repository.IRepository;

namespace LibraryAppNi.Shared.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryDbContext _db;
        private readonly IMapper _mapper;

        public BookDto Create(BookDto bookDto)
        {
            var book = _mapper.Map<BookDto, Book>(bookDto);

            _db.Add(book);
            _db.SaveChangesAsync();

            return _mapper.Map<Book, BookDto>(book);
        }

        public int Delete(int id)
        {
            var book = _db.Books.FirstOrDefault(book => book.BookId == id);

            if (book != null)
            {
                _db.Remove(book);

                return _db.SaveChanges();
            }

            return 0;
        }

        public BookDto Get(int id)
        {
            var book = _db.Books.FirstOrDefault(book => book.BookId == id);

            if (book != null)
            {
                return _mapper.Map<Book, BookDto>(book);
            }

            return new BookDto();
        }

        public IEnumerable<BookDto> GetAll()
        {
            return _mapper.Map<IEnumerable<Book>, IEnumerable<BookDto>>(_db.Books);
        }

        public BookDto Update(BookDto bookDto)
        {
            var book = _db.Books.FirstOrDefault(book => book.BookId == bookDto.BookId);

            if (book != null)
            {
                book.Title = bookDto.Title;
                book.Author = bookDto.Author;
                book.Publisher = bookDto.Publisher;
                book.PublishYear = bookDto.PublishYear;
                book.IsBorrowed = bookDto.IsBorrowed;

                _db.Books.Update(book);
                _db.SaveChanges();

                return _mapper.Map<Book, BookDto>(book);
            }

            return bookDto;
        }
    }
}
