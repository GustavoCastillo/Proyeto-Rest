using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookStore.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using WebServer.Data;

namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly BookStoreContext _context;
        public CategoryRepository Repository { get; private set; }

        public CategoriesController(IHostingEnvironment environment,
            IConfiguration configuration, CategoryRepository repository)
        {
            Repository = repository;
        }

        // GET: api/Categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategory()
        {
            var data = Repository.Get().AsQueryable();

            var result = new ObjectResult(data)
            {
                StatusCode = (int)HttpStatusCode.OK
            };

            Response.Headers.Add("X-Total-Count", new StringValues(data.Count().ToString()));
            Response.Headers.Add("page-size", new StringValues(data.Count().ToString()));

            return result;
        }

        // GET: api/Categories/5
        [HttpGet("{id}", Name = nameof(GetCategory))]
        public async Task<ActionResult<Category>> GetCategory(int id)
        {
            var data = Repository.Get(id);

            var result = new ObjectResult(data)
            {
                StatusCode = (int)HttpStatusCode.OK
            };

            return result;
        }

        // PUT: api/Categories/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory([FromRoute] int id, [FromBody] Category category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var model = Repository.Get(id);

            if (model == null)
            {
                return NotFound();
            }
            
            Repository.Update(id, category);

            return Ok();
        }

        // POST: api/Categories
        [HttpPost]
        public async Task<ActionResult<Category>> PostCategory(Category category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var id = Repository.Add(category);

            return CreatedAtAction(nameof(GetCategory), new { Id = id }, category);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Category>> DeleteCategory([FromRoute] int id)
        {
            if (Repository.Get(id) == null)
            {
                return NotFound();
            }
            Repository.Delete(id);

            return Ok();
        }

        //private bool CategoryExists(int id)
        //{
        //    return _context.Category.Any(e => e.Id == id);
        //}
    }
}
