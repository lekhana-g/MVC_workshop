using bookfapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookfapi.Repo{
    public class BookFRepo : IBookF{
        BookF b=new BookF();
        public void AddBookingF(BookF b)
        {
            b.AddBookF(b);
        }
        public void CancelBooking(int id)
        {
            b.DeleteBooking(id);
        }
        public BookF getBookingById(int id)
        {
            return b.GetBookingById(id);
        }
        public List<BookF> getBookings()
        {
            return b.getBDetails();
        }
    }
}
