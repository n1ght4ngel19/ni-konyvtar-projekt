using LibraryAppNi.Shared.Model.BaseClass;
using Newtonsoft.Json;
using System.Text;

namespace LibraryAppNi.LibrarianApp.ViewModels
{
    public class BooksUpdateInsertViewModel: IBooksUpdateInsertViewModel
    {
        private const string Url = "http://localhost:5000/api/book";


        public void CreateBook(Book book)
        {
            using (var client = new HttpClient())
            {
                var rawData = JsonConvert.SerializeObject(book);
                var content = new StringContent(rawData, Encoding.UTF8, "application/json");

                var response = client.PostAsync(Url, content).Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }

        public void UpdateBook(Book book)
        {
            using (var client = new HttpClient())
            {
                var rawData = JsonConvert.SerializeObject(book);
                var content = new StringContent(rawData, Encoding.UTF8, "application/json");

                var response = client.PutAsync(Url, content).Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }

        public void DeleteBook(long id)
        {
            using (var client = new HttpClient())
            {
                var response = client.DeleteAsync($"{Url}/{id}").Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }
    }
}
