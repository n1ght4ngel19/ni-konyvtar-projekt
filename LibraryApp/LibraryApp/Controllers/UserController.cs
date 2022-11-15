using Books_Project.Models;
using LibraryApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {

        /// <summary>
        /// Returns all User entities in the db.
        /// </summary>
        /// <returns>Ok(user)</returns>
        [HttpGet]
        public ActionResult<IEnumerable<Users>> Get()
        {
            var user = UsersRepository.GetUsers();
            return Ok(user);
        }

        /// <summary>
        /// Returns User based on provided id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Ok() if successful, NotFound() if not</returns>
        [HttpGet("{id}")]
        public ActionResult<Users> Get(int id)
        {
            var user = UsersRepository.GetUser(id);

            if (user != null)
            {
                return Ok(user);
            }
            else
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Adds the given User to the db.
        /// </summary>
        /// <param name="user">User to be added</param>
        /// <returns>Ok()</returns>
        [HttpPost]
        public ActionResult Post(Users user)
        {
            UsersRepository.AddUser(user);

            return Ok();
        }

        /// <summary>
        /// Updates User of id (id) to given Book
        /// </summary>
        /// <param name="user">User to update already existing one to</param>
        /// <param name="id">Id of User to be updated</param>
        /// <returns>Ok() if successful, NotFound() if not</returns>
        [HttpPut("{id}")]
        public ActionResult Put(Users user, int id)
        {
            var successful = UsersRepository.UpdateUser(user, id);
            if (successful)
            {
                return Ok();
            }
            return NotFound();
        }

        /// <summary>
        /// Deletes a User based on id given.
        /// </summary>
        /// <param name="id">Id of the User to be deleted</param>
        /// <returns>Ok() if successful, NotFound() if not.</returns>
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var user = UsersRepository.GetUser(id);

            if (user != null)
            {
                UsersRepository.DeleteUser(user);
                return Ok();
            }

            return NotFound();
        }
    }

}
