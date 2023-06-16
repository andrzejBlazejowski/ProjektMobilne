﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReaderController : ControllerBase
    {
        private readonly BooksAPIContext _context;

        public ReaderController(BooksAPIContext context)
        {
            _context = context;
        }

        // GET: api/Reader
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reader>>> GetReader()
        {
          if (_context.Reader == null)
          {
              return NotFound();
          }
            return await _context.Reader.ToListAsync();
        }

        // GET: api/Reader/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Reader>> GetReader(int id)
        {
          if (_context.Reader == null)
          {
              return NotFound();
          }
            var reader = await _context.Reader.FindAsync(id);

            if (reader == null)
            {
                return NotFound();
            }

            return reader;
        }

        // PUT: api/Reader/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReader(int id, Reader reader)
        {
            if (id != reader.Id)
            {
                return BadRequest();
            }

            _context.Entry(reader).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReaderExists(id))
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

        // POST: api/Reader
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Reader>> PostReader(Reader reader)
        {
          if (_context.Reader == null)
          {
              return Problem("Entity set 'BooksAPIContext.Reader'  is null.");
          }
            _context.Reader.Add(reader);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReader", new { id = reader.Id }, reader);
        }

        // DELETE: api/Reader/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReader(int id)
        {
            if (_context.Reader == null)
            {
                return NotFound();
            }
            var reader = await _context.Reader.FindAsync(id);
            if (reader == null)
            {
                return NotFound();
            }

            _context.Reader.Remove(reader);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReaderExists(int id)
        {
            return (_context.Reader?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
