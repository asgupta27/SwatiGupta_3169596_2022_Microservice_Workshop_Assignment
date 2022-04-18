using BookingAPI.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingAPI.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private static readonly IList<Booking> _bookings = new List<Booking>();
            
        public Task<Booking> CreateBooking(Booking booking)
        {
            int maxID = _bookings.Select(x => x.BookingId).Max();
            booking.BookingId = maxID + 1;
            _bookings.Add(booking);
            return Task.FromResult(booking);
        }
    }
}
