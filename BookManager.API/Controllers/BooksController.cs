using BookManager.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookManager.API.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        // POST api/books
        [HttpPost]
        public IActionResult Post(CreateBookInputModel model)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1 }, model);
        }

        // GET api/books
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        // GET api/books/:id
        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            return Ok();
        }

        // PUT api/books/:id
        [HttpPut("{id}")]
        public IActionResult Update(int id, UpdateBookInputModel model)
        {
            return NoContent();
        }

        // DELETE api/books/:id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }

    }
}
