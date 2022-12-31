using AutoMapper;
using LibraryAppNi.Data.Database;
using LibraryAppNi.Data.Library;
using LibraryAppNi.Data.Repository.IRepository;

namespace LibraryAppNi.Data.Repository
{
    public class BorrowRepository : IBorrowRepository
    {
        private readonly LibraryDbContext _db;
        private readonly IMapper _mapper;

        public BorrowRepository(LibraryDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public BorrowDto Create(BorrowDto borrowDto)
        {
            var borrow = _mapper.Map<BorrowDto, Borrow>(borrowDto);

            _db.Add(borrow);
            _db.SaveChanges();

            return _mapper.Map<Borrow, BorrowDto>(borrow);
        }

        public int Delete(int borrowId)
        {
            var borrow = _db.Borrows.FirstOrDefault(u => u.BorrowId == borrowId);

            if (borrow != null)
            {
                _db.Borrows.Remove(borrow);

                return _db.SaveChanges();
            }

            return 0;
        }

        public BorrowDto Get(int borrowId)
        {
            var borrow = _db.Borrows.FirstOrDefault(u => u.BorrowId == borrowId);

            if (borrow != null)
            {
                return _mapper.Map<Borrow, BorrowDto>(borrow);
            }

            return new BorrowDto();
        }

        public IEnumerable<BorrowDto> GetAll()
        {
            return _mapper.Map<IEnumerable<Borrow>, IEnumerable<BorrowDto>>(_db.Borrows);
        }

        public BorrowDto Update(BorrowDto borrowDto)
        {
            var borrow = _db.Borrows.FirstOrDefault(u => u.BorrowId == borrowDto.BorrowId);

            if (borrow != null)
            {
                borrow.MemberId = borrowDto.MemberId;
                borrow.BookId = borrowDto.BookId;
                borrow.BorrowDate = borrowDto.BorrowDate;
                borrow.BorrowDeadline = borrowDto.BorrowDeadline;

                _db.Borrows.Update(borrow);
                _db.SaveChanges();

                return _mapper.Map<Borrow, BorrowDto>(borrow);
            }

            return borrowDto;
        }
    }
}
