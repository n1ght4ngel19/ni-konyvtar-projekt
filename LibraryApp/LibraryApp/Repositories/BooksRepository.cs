﻿using Books_Project.Models;
using LibraryApp.Context;
using System;

namespace LibraryApp.Repositories
{
    public static class BooksRepository
    {

        /// <summary>
        /// Method to get all Book objects.
        /// </summary>
        /// <returns>Returns all Books.</returns>
        public static IList<Books> GetBooks()
        {
            using (var database = new BooksContext())
            {
                var books = database.Books.ToList();

                return books;
            }
        }

        /// <summary>
        /// Returns the Book of the corresponding ID.
        /// </summary>
        /// <param name="id">ID of the Book we want to get.</param>
        /// <returns>The Book which's ID we gave</returns>
        public static Books GetBook(long id)
        {
            using (var database = new BooksContext())
            {
                var book = database.Books.Where(p => p.Id == id).FirstOrDefault();

                return book;
            }
        }

        /// <summary>
        /// Adds the given book to the database.
        /// </summary>
        /// <param name="book">The book object we want to add to the database</param>
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

        /// <summary>
        /// Deletes the given book from the database
        /// </summary>
        /// <param name="book">Book to be deleted from the database</param>
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
