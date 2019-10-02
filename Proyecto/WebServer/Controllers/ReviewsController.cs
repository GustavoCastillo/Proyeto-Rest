using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookStore.Models;
using WebServer.Models;

namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly BookStoreContext _context;

        public ReviewsController(BookStoreContext context)
        {
            _context = context;
        }

        // GET: api/Reviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Review>>> GetReview()
        {
            return await _context.Review.ToListAsync();
        }

        // GET: api/Reviews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Review>> GetReview(int id)
        {
            var review = await _context.Review.FindAsync(id);

            if (review == null)
            {
                return NotFound();
            }

            return review;
        }

        // PUT: api/Reviews/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReview(int id, Review review)
        {
            if (id != review.Id)
            {
                return BadRequest();
            }

            _context.Entry(review).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReviewExists(id))
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

        // POST: api/Reviews
        [HttpPost]
        public async Task<ActionResult<Review>> PostReview(Review review)
        {
            _context.Review.Add(review);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReview", new { id = review.Id }, review);
        }

        // DELETE: api/Reviews/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Review>> DeleteReview(int id)
        {
            var review = await _context.Review.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }

            _context.Review.Remove(review);
            await _context.SaveChangesAsync();

            return review;
        }

        private bool ReviewExists(int id)
        {
            return _context.Review.Any(e => e.Id == id);
        }

        // GET: api/ReviewsBook/5
        [HttpGet("book/{id}")]
        public async Task<ActionResult<IEnumerable<Review>>> GetReviewByBook(int id)
        {
            var review = await _context.Review.Where(x => x.IdLibro == id).ToListAsync();
            //ReadAsAsync<IList<Category>>()



            if (review == null)
            {
                return NotFound();
            }

            return review;
        }

        [HttpGet("popular")]
        public async Task<IList<Popular>> GetMostPopular()
        {

            var contextReview = _context.Review.ToList();
            var contextBook = _context.Book.ToList();

            var dbDataSorted = (from book1 in contextBook
                               join review1 in contextReview on book1.Id equals review1.IdLibro
                               group new { book1, review1 } by new { book1.Name, book1.Description, book1.Category } into g
                               select new Popular
                               {
                                   Name = g.Key.Name,
                                   Description = g.Key.Description,
                                   Category = g.Key.Category,
                                   Votes = g.Sum(pt => pt.review1.Votes),
                               }).OrderByDescending(x=>x.Votes);

            return dbDataSorted.ToList();
        }

    }
}
