using System.Security.Cryptography.X509Certificates;
using AutoMapper;
using LibraryAppNi.Shared.DataBase;
using LibraryAppNi.Shared.Model.BaseClass;
using LibraryAppNi.Shared.Model.DTO;
using LibraryAppNi.Shared.Repository.IRepository;

namespace LibraryAppNi.Shared.Repository
{
    public class BorrowRepository : IBorrowRepository
    {
        private readonly LibraryDbContext _db;
        private readonly IMapper _mapper;

        public BorrowDto Create(BorrowDto borrowDto)
        {
            var borrow = _mapper.Map<BorrowDto, Borrow>(borrowDto);

            _db.Add(borrow);
            _db.SaveChangesAsync();

            return _mapper.Map<Borrow, BorrowDto>(borrow);
        }

        public int Delete(int id)
        {
            var borrow = _db.Borrows.FirstOrDefault(borrow => borrow.BorrowId == id);

            if (borrow != null)
            {
                _db.Remove(borrow);

                return _db.SaveChanges();
            }

            return 0;
        }

        public BorrowDto Get(int id)
        {
            var borrow = _db.Borrows.FirstOrDefault(borrow => borrow.BorrowId == id);

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
            var borrow = _db.Borrows.FirstOrDefault(borrow => borrow.BorrowId == borrowDto.BorrowId);

            if (borrow != null)
            {
                borrow.BorrowDate = borrowDto.BorrowDate;
                borrow.BorrowDeadline = borrowDto.BorrowDeadline;
                borrow.BookId = borrowDto.BookId;
                borrow.MemberId = borrowDto.MemberId;

                _db.Borrows.Update(borrow);
                _db.SaveChanges();

                return _mapper.Map<Borrow, BorrowDto>(borrow);
            }

            return borrowDto;
        }
    }
}
