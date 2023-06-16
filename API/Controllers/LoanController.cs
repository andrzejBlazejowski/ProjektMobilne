using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        private readonly BooksAPIContext _context;

        public LoanController(BooksAPIContext context)
        {
            _context = context;
        }

        // GET: api/Loan
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Loan>>> GetLoan()
        {
          if (_context.Loan == null)
          {
              return NotFound();
          }
            return await _context.Loan.ToListAsync();
        }

        // GET: api/Loan/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Loan>> GetLoan(int id)
        {
          if (_context.Loan == null)
          {
              return NotFound();
          }
            var loan = await _context.Loan.FindAsync(id);

            if (loan == null)
            {
                return NotFound();
            }

            return loan;
        }

        // PUT: api/Loan/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoan(int id, Loan loan)
        {
            if (id != loan.Id)
            {
                return BadRequest();
            }

            _context.Entry(loan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoanExists(id))
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

        // POST: api/Loan
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Loan>> PostLoan(Loan loan)
        {
          if (_context.Loan == null)
          {
              return Problem("Entity set 'BooksAPIContext.Loan'  is null.");
          }
            _context.Loan.Add(loan);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLoan", new { id = loan.Id }, loan);
        }

        // DELETE: api/Loan/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLoan(int id)
        {
            if (_context.Loan == null)
            {
                return NotFound();
            }
            var loan = await _context.Loan.FindAsync(id);
            if (loan == null)
            {
                return NotFound();
            }

            _context.Loan.Remove(loan);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LoanExists(int id)
        {
            return (_context.Loan?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
