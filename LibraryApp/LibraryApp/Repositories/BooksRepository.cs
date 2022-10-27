using Books_Project.Models;
using System;

namespace LibraryApp.Repositories
{
    public static class BooksRepository
    {

        public static IList<Books> GetBooks()
        {
            using (var database = new BooksContext())
            {
                var books = database.Books.ToList();

                return books;
            }
        }

        public static Books GetBook(long id)
        {
            using (var database = new BooksContext())
            {
                var book = database.Books.Where(p => p.Id == id).FirstOrDefault();

                return book;
            }
        }

        public static void AddBook(Books book)
        {
            using (var database = new BooksContext())
            {
                database.Books.Add(book);

                database.SaveChanges();
            }
        }

        public static bool UpdateBook(Books book, long id)
        {
            using (var database = new BooksContext())
            {
                var dbBook = database.Books.Where(p => p.Id == id).FirstOrDefault();
                if (dbBook != null)
                {
                    database.Books.Update(book);

                    database.SaveChanges();

                    return true;

                }
                return false;

                // database.Books.Update(book);

                // database.SaveChanges();
            }
        }

        public static void DeleteBook(Books book)
        {
            using (var database = new BooksContext())
            {
                database.Books.Remove(book);

                database.SaveChanges();
            }
        }
    }
}
