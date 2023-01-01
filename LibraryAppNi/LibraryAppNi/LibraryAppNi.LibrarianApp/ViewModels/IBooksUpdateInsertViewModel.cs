using Newtonsoft.Json;
using System.Text;
using System;
using LibraryAppNi.Shared.Model.BaseClass;

namespace LibraryAppNi.LibrarianApp.ViewModels
{
    public interface IBooksUpdateInsertViewModel
    {

         void CreateBook(Book book);
         void UpdateBook(Book book);
         void DeleteBook(long id);
    }
}
