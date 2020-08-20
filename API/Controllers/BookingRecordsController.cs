using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data ;
using API.Entities ;
using System ;
using System.IO ;

namespace API.Controllers
{
    [Route ("api/[controller]")]
    [ApiController]
    public class BookingRecordsController: ControllerBase 
    {
         private readonly DataContext _context;

        public BookingRecordsController (DataContext context) {
            _context = context;
        }
         

          // GET: api/BookingRecords
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookingRecord>>> GetBookingRecords() {
            return await _context.BookingRecords.ToListAsync ();
        }

     
          // GET: api/BookingRecord/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookingRecord>> GetBookingRecords(int id)
        {
            var bookrecord = await _context.BookingRecords.FindAsync(id);

            if (bookrecord == null)
            {
                return NotFound();
            }

            return bookrecord;
        }

           // POST: api/BookingRecords
        [HttpPost]
        public async Task<ActionResult<BookingRecord>> PostBookingRecords(BookingRecord bookingRecords)
        {
            bookingRecords.Status = "Not Returned";
			_context.BookingRecords.Add(bookingRecords);
			var results = await _context.SaveChangesAsync();
            updateBook (bookingRecords.BookId);
            


			return  Ok(results) ;
        }

        [HttpPost]
        [Route("ReturnBook")]
        public async Task<ActionResult<BookingRecord>> ReturnBook(BookingRecord bookingRecords)
        {
            bookingRecords.Status = "Not Returned";
			_context.BookingRecords.Add(bookingRecords);
			var results = await _context.SaveChangesAsync();
            updateBook (bookingRecords.BookId);
            updateRecord (bookingRecords) ;
            


			return  Ok(results) ;
        }

        private void updateBook (int id)
        { 
             var book = _context.Books.Where(b => b.BookId == id).FirstOrDefault<Book>() ;

             if ( book.Status == "On Loan")
             { 
                  book.Status = "Available" ;
             }
             else if ( book.Status == "Available")
             { 
                  book.Status = "On Loan" ;
             }
            

             _context.Entry(book).State = EntityState.Modified;
            try
            {
                _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {               
               throw;                
            }
        }


         private void updateRecord (BookingRecord bookingRecord)
        { 
             var bookrecord = _context.BookingRecords.Where(b => b.BookingRecordId == bookingRecord.BookingRecordId).FirstOrDefault<BookingRecord>() ;

             
                  bookrecord.Status = "Returned" ;
                  bookrecord.ReturnedBy = bookingRecord.ReturnedBy ;
                  bookrecord.ReturnedOn = bookingRecord.ReturnedOn ;
            
            

             _context.Entry(bookrecord).State = EntityState.Modified;
            try
            {
                _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {               
               throw;                
            }
        }
        
        private bool BookingRecordExists(int id)
        {
            return _context.BookingRecords.Any(e => e.BookingRecordId == id);
        }
        
    }
}