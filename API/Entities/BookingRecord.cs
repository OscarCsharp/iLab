using System.ComponentModel.DataAnnotations ;
using System.Collections ;
using System ;

namespace API.Entities
{
    public class BookingRecord
    {
       
        public int BookingRecordId {get;set;}
        public string CurrentOwner {get;set;}

       public string CellNo {get;set;}

        public string Email {get;set;}

        [DataType(DataType.Date)]
        public DateTime RequestedDate {get;set;}

        [DataType(DataType.Date)]
        public DateTime ReturnDate {get;set;}
        public string Status {get;set;}

        [DataType(DataType.Date)]
        public DateTime ReturnedOn {get;set;}
        public string ReturnedBy {get;set;}

        public int BookId {get;set;}
        public Book Book { get; set; }
    }
}
