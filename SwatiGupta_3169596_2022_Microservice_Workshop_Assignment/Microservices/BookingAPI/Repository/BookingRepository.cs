using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingAPI
{
    public class BookingRepository : IBookingRepository
    {
        private static readonly IList<Booking> _bookings = new List<Booking>();
         
        /// <summary>
        /// Create Booking
        /// </summary>
        /// <param name="booking"></param>
        /// <returns></returns>
        public Task<Booking> CreateBooking(Booking booking)
        {
            int maxID = 0;
            if (_bookings != null && _bookings.Count() > 0)
            {
                maxID = _bookings.Select(x => x.BookingId).Max();
            }
            booking.BookingId = maxID + 1;
            _bookings.Add(booking);
            return Task.FromResult(booking);
        }

        /// <summary>
        /// Get all booking list
        /// </summary>
        /// <returns></returns>
        public Task<IList<Booking>> GetBookings()
        {
            return Task.FromResult(_bookings);
        }
    }
}
