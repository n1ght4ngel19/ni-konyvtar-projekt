using Books_Project.Models;
using LibraryApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Controllers
{
    [Route("api/rental")]
    [ApiController]
    public class RentalController : ControllerBase
    {
        /// <summary>
        /// Returns all Rental entities in the db.
        /// </summary>
        /// <returns>Ok(rent)</returns>
        [HttpGet]
        public ActionResult<IEnumerable<Rental>> Get()
        {
            var rent = RentalRepository.GetRentals();
            return Ok(rent);
        }

        /// <summary>
        /// Returns Rental based on provided id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Ok(rent) if successful, NotFound() if not</returns>
        [HttpGet("{id}")]
        public ActionResult<Rental> Get(int id)
        {
            var rent = RentalRepository.GetRental(id);

            if (rent != null)
            {
                return Ok(rent);
            }
            else
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Adds the given Rental to the db.
        /// </summary>
        /// <param name="rent">Rental to be added</param>
        /// <returns>Ok()</returns>
        [HttpPost]
        public ActionResult Post(Rental rent)
        {
            RentalRepository.AddRental(rent);

            return Ok();
        }

        /// <summary>
        /// Updates Rental of id (id) to given Book
        /// </summary>
        /// <param name="rent">Rental to update already existing one to</param>
        /// <param name="id">Id of Rental to be updated</param>
        /// <returns>Ok() if successful, NotFound() if not</returns>
        [HttpPut("{id}")]
        public ActionResult Put(Rental rent, int id)
        {
            var successful = RentalRepository.UpdateRental(rent, id);
            if (successful)
            {
                return Ok();
            }
            return NotFound();
        }

        /// <summary>
        /// Deletes a Rental based on id given.
        /// </summary>
        /// <param name="id">Id of the Rental to be deleted</param>
        /// <returns>Ok() if successful, NotFound() if not.</returns>
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var rent = RentalRepository.GetRental(id);

            if (rent != null)
            {
                RentalRepository.DeleteRental(rent);
                return Ok();
            }

            return NotFound();
        }
    }
}
