using System.Net;
using AutoMapper;
using LibraryAppNi.Data.Database;
using LibraryAppNi.Data.Library;
using LibraryAppNi.Data.Repository.IRepository;

namespace LibraryAppNi.Data.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryDbContext _db;
        private readonly IMapper _mapper;

        public BookRepository(LibraryDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public BookDto Create(BookDto bookDto)
        {
            var book = _mapper.Map<BookDto, Book>(bookDto);

            _db.Add(book);
            _db.SaveChanges();

            return _mapper.Map<Book, BookDto>(book);
        }

        public int Delete(int bookId)
        {
            var book = _db.Books.FirstOrDefault(u => u.BookId == bookId);

            if (book != null)
            {
                _db.Books.Remove(book);

                return _db.SaveChanges();
            }

            return 0;
        }

        public BookDto Get(int bookId)
        {
            var book = _db.Books.FirstOrDefault(u => u.BookId == bookId);

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
            var book = _db.Books.FirstOrDefault(u => u.BookId == bookDto.BookId);
        
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
