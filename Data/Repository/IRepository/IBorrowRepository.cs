using LibraryAppNi.Data.Model;

namespace LibraryAppNi.Data.Repository.IRepository
{
    public interface IBorrowRepository
    {
        public BorrowDto Create(BorrowDto borrowDto);
        public BorrowDto Update(BorrowDto borrowDto);
        public int Delete(int borrowId);
        public BorrowDto Get(int borrowId);
        public IEnumerable<BorrowDto> GetAll();
        public bool ValidateDeadLine(DateTime start, DateTime end);
    }
}
