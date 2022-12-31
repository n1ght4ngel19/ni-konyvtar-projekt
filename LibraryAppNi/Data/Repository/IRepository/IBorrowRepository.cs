using LibraryAppNi.Data.Library;

namespace LibraryAppNi.Data.Repository.IRepository
{
    public interface IBorrowRepository
    {
        public BorrowDto Create(BorrowDto borrowDto);
        public BorrowDto Update(BorrowDto borrowDto);
        public int Delete(int borrowId);
        public BorrowDto Get(int borrowId);
        public IEnumerable<BorrowDto> GetAll();
    }
}
