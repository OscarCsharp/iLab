using System.ComponentModel.DataAnnotations ;
using System.Collections.Generic;



namespace API.Entities
{
    public class Book
    {
       
        public int BookId {get;set;}
        public string Title {get;set;}
        public string Author {get ;set;}
        public string Description {get;set;}
        public string Year {get;set;}
        public string Status {get ;set;}
        public virtual ICollection<BookingRecord> BookingRecords { get; set; }


    }
    
  
}