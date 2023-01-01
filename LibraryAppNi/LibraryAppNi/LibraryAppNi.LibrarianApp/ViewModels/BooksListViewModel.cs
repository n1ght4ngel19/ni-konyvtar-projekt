using LibraryAppNi.Shared.Model.BaseClass;
using Newtonsoft.Json;

namespace LibraryAppNi.LibrarianApp.ViewModels
{
    public class BooksListViewModel : IBooksListViewModel
    {
        private const string Url = "http://localhost:5000/api/book";

        public List<Book> Books { get; set; }
        public IEnumerable<Book> GetBooks()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(Url).Result;

                if (response.IsSuccessStatusCode)
                {
                    var rawData = response.Content.ReadAsStringAsync().Result;
                    var books = JsonConvert.DeserializeObject<IEnumerable<Book>>(rawData);
                    Books = (List<Book>)books;
                    return books;
                }

                throw new InvalidOperationException(response.StatusCode.ToString());
            }
        }
    }
}
