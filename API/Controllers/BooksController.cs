using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data ;
using API.Entities ;



namespace API.Controllers
{
    [Route ("api/[controller]")]
    [ApiController]
    public class BooksController: ControllerBase 
    {
        private readonly DataContext _context;

        public BooksController (DataContext context) {
            _context = context;
        }
         

          // GET: api/Books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks () {
            return await _context.Books.ToListAsync ();
        }

        [HttpGet]
        [Route("GetAvailableBooks")]
        public  IEnumerable<Book> GetAvailableBooks () {
            var books = _context.Books.Where(b => b.Status == "Available").ToList();
            return books ;
        }

        [HttpGet]
        [Route("GetLoanedBooks")]
        public  IEnumerable<Book> GetLoanedBooks () {
            var books = _context.Books.Where(b => b.Status == "On Loan").ToList();
            return books ;
        }

         // GET: api/Book/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await _context.Books.FindAsync(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        // PUT: api/Books/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBook(int id, Book book)
        {
            if (id != book.BookId)
            {
                return BadRequest();
            }

            _context.Entry(book).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(id))
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


         // POST: api/Books
        [HttpPost]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
            book.Status = "Available" ;
			_context.Books.Add(book);
			var results = await _context.SaveChangesAsync();

			return  Ok(results) ;
        }

         // DELETE: api/Book/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Book>> DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            return book;
        }

         private bool BookExists(int id)
        {
            return _context.Books.Any(e => e.BookId == id);
        }



    }
}