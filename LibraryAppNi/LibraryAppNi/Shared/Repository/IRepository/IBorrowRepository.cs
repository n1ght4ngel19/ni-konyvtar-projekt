using LibraryAppNi.Shared.Model.DTO;

namespace LibraryAppNi.Shared.Repository.IRepository
{
    public interface IBorrowRepository
    {
        public BorrowDto Create(BorrowDto borrowDto);
        public BorrowDto Update(BorrowDto borrowDto);
        public BorrowDto Get(int id);
        public IEnumerable<BorrowDto> GetAll();
        public int Delete(int id);
    }
}
