using LibraryAppNi.Shared.Model.BaseClass;

namespace LibraryAppNi.Client.ViewModels
{
    public interface IMembersMainViewViewModel
    {
        List<Book> Books { get; set; }
        Task GetBooks();
    }
}
