using Microsoft.AspNetCore.Mvc;
using Books_Project.Models;
using LibraryApp.Repositories;
using System;

namespace LibraryApp.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        /// <summary>
        /// Returns all Book entities in the db.
        /// </summary>
        /// <returns>Ok(books)</returns>
        [HttpGet]
        public ActionResult<IEnumerable<Books>> Get()
        {
            var books = BooksRepository.GetBooks();
            return Ok(books);
        }

        /// <summary>
        /// Returns Book based on provided id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Ok() if successful, NotFound() if not</returns>
        [HttpGet("{id}")]
        public ActionResult<Books> Get(long id)
        {
            var book = BooksRepository.GetBook(id);

            if (book != null)
            {
                return Ok(book);
            }
            else
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Adds the given Book to the db.
        /// </summary>
        /// <param name="book">Book to be added</param>
        /// <returns>Ok()</returns>
        [HttpPost]
        public ActionResult Post(Books book)
        {
            BooksRepository.AddBook(book);

            return Ok();
        }

        /// <summary>
        /// Updates Book of id (id) to given Book
        /// </summary>
        /// <param name="book">Book to update already existing one to</param>
        /// <param name="id">Id of Book to be updated</param>
        /// <returns>Ok() if successful, NotFound() if not</returns>
        [HttpPut("{id}")]
        public ActionResult Put(Books book, long id)
        {
            var successful = BooksRepository.UpdateBook(book, id);
            if (successful)
            {
                return Ok();
            }
            return NotFound();

            /*
            var dbBook = BooksRepository.GetBook(id);

            if (dbBook != null)
            {
                BooksRepository.UpdateBook(book);
                return Ok();
            }

            return NotFound();
            */
        }

        /// <summary>
        /// Deletes a Book based on id given.
        /// </summary>
        /// <param name="id">Id of the Book to be deleted</param>
        /// <returns>Ok() if successful, NotFound() if not.</returns>
        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            var book = BooksRepository.GetBook(id);

            if (book != null)
            {
                BooksRepository.DeleteBook(book);
                return Ok();
            }

            return NotFound();
        }
    }
}
