using LibraryAppNi.Shared.Model.BaseClass;

namespace LibraryAppNi.LibrarianApp.ViewModels
{
    public interface IBooksListViewModel
    {
        List<Book> Books { get; set; }
        IEnumerable<Book> GetBooks();
    }
}
