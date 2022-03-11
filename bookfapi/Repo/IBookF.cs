using bookfapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookfapi.Repo
{
    interface IBookF
    {
        public void AddBookingF(BookF b);
        public void CancelBooking(int id);
        public List<BookF> getBookings();
        public BookF getBookingById(int id);

    }
}
