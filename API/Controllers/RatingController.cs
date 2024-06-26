﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Model;
using API.Helpers;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly BooksAPIContext _context;

        public RatingController(BooksAPIContext context)
        {
            _context = context;
        }

        // GET: api/Rating
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rating>>> GetRating()
        {
          if (_context.Rating == null)
          {
              return NotFound();
          }

            var rating = await _context.Rating.ToListAsync();

            rating.ForEach((rating) =>
            {
                rating = associationsHelper.getRatingWithAssociations(rating, _context);
            });

            return rating;
        }

        // GET: api/Rating/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rating>> GetRating(int id)
        {
          if (_context.Rating == null)
          {
              return NotFound();
          }
            var rating = await _context.Rating.FindAsync(id);

            if (rating == null)
            {
                return NotFound();
            }

            rating = associationsHelper.getRatingWithAssociations(rating, _context);

            return rating;
        }

        // PUT: api/Rating/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRating(int id, Rating rating)
        {
            if (id != rating.Id)
            {
                return BadRequest();
            }

            _context.Entry(rating).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RatingExists(id))
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

        // POST: api/Rating
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Rating>> PostRating(Rating rating)
        {
          if (_context.Rating == null)
          {
              return Problem("Entity set 'BooksAPIContext.Rating'  is null.");
          }
            _context.Rating.Add(rating);
            await _context.SaveChangesAsync();

            rating = associationsHelper.getRatingWithAssociations(rating, _context);

            return CreatedAtAction("GetRating", new { id = rating.Id }, rating);
        }

        // DELETE: api/Rating/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRating(int id)
        {
            if (_context.Rating == null)
            {
                return NotFound();
            }
            var rating = await _context.Rating.FindAsync(id);
            if (rating == null)
            {
                return NotFound();
            }

            _context.Rating.Remove(rating);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RatingExists(int id)
        {
            return (_context.Rating?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
