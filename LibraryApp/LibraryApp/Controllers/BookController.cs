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
        [HttpGet]
        public ActionResult<IEnumerable<Books>> Get()
        {
            var book = BooksRepository.GetBooks();
            return Ok(book);
        }

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

        [HttpPost]
        public ActionResult Post(Books book)
        {
            BooksRepository.AddBook(book);

            return Ok();
        }

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
