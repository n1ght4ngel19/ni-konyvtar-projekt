using LibraryAppNi.Shared.Model.BaseClass;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace LibraryAppNi.Client.ViewModels
{
    public class MembersMainViewViewModel : IMembersMainViewViewModel
    {
        public List<Book> Books { get; set; } = new List<Book>();


        private const string Url = "http://localhost:5000/api/book";

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
