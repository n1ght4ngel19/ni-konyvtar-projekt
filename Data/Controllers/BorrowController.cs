using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LibraryAppNi.Data.Database;
using LibraryAppNi.Data.Library;

namespace LibraryAppNi.Data.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowController : ControllerBase
    {
        private readonly LibraryDbContext _context;

        public BorrowController(LibraryDbContext context)
        {
            _context = context;
        }

        // GET: api/Borrow
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Borrow>>> GetBorrows()
        {
            return await _context.Borrows.ToListAsync();
        }

        // GET: api/Borrow/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Borrow>> GetBorrow(int id)
        {
            var borrow = await _context.Borrows.FindAsync(id);

            if (borrow == null)
            {
                return NotFound();
            }

            return borrow;
        }

        // PUT: api/Borrow/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBorrow(int id, Borrow borrow)
        {
            if (id != borrow.BorrowId)
            {
                return BadRequest();
            }

            _context.Entry(borrow).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BorrowExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Borrow
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Borrow>> PostBorrow(Borrow borrow)
        {
            _context.Borrows.Add(borrow);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBorrow", new { id = borrow.BorrowId }, borrow);
        }

        // DELETE: api/Borrow/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBorrow(int id)
        {
            var borrow = await _context.Borrows.FindAsync(id);
            if (borrow == null)
            {
                return NotFound();
            }

            _context.Borrows.Remove(borrow);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BorrowExists(int id)
        {
            return _context.Borrows.Any(e => e.BorrowId == id);
        }
    }
}
