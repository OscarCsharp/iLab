using System ;

namespace API.Model
{
    public class BookingModel
    {
         int BookingRecordId {get;set;}
        public string CurrentOwner {get;set;}
        public DateTime RequestedDate {get;set;}
        public DateTime ReturnDate {get;set;}
    }
}