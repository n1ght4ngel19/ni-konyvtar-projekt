using LibraryAppNi.Shared.Model.DTO;

namespace LibraryAppNi.Server.Repository.IRepository
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
