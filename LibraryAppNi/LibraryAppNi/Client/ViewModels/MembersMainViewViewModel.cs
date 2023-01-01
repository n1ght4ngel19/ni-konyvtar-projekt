using LibraryAppNi.Shared.Model.BaseClass;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace LibraryAppNi.Client.ViewModels
{
    public class MembersMainViewViewModel : IMembersMainViewViewModel
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public MembersMainViewViewModel(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }

        public List<Book> Books { get; set; } = new List<Book>();


        public async Task GetBooks()
        {
            var result = await _http.GetFromJsonAsync<List<Book>>("api/book");
            if (result != null)
            {
                Books = result;
            }
        }
    }
}
