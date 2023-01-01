using AutoMapper;
using LibraryAppNi.Data.Database;
using LibraryAppNi.Data.Model;
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

            _ = _db.Add(borrow);
            _ = _db.SaveChanges();

            return _mapper.Map<Borrow, BorrowDto>(borrow);
        }

        public int Delete(int borrowId)
        {
            var borrow = _db.Borrows.FirstOrDefault(u => u.BorrowId == borrowId);

            if (borrow != null)
            {
                _ = _db.Borrows.Remove(borrow);

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

                _ = _db.Borrows.Update(borrow);
                _ = _db.SaveChanges();

                return _mapper.Map<Borrow, BorrowDto>(borrow);
            }

            return borrowDto;
        }

        public bool ValidateDeadLine(DateTime start, DateTime end)
        {
            return end > start;
        }
    }
}
