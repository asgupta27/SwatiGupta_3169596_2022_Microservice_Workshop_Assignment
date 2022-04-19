using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingAPI
{
    public class BookingRepository : IBookingRepository
    {
        private static readonly IList<Booking> _bookings = new List<Booking>();

        /// <summary>
        /// Create booking
        /// </summary>
        /// <param name="booking">The booking model</param>
        /// <returns>Return created booking order</returns>
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
        /// <returns>Returns booking list</returns>
        public Task<IList<Booking>> GetBookings()
        {
            return Task.FromResult(_bookings);
        }

        /// <summary>
        /// Update service providers details
        /// </summary>
        /// <param name="bookingId">The booking model</param>
        /// <returns>Returns the updated booking obj</returns>
        public Task<Booking> UpdateServiceProvidersDeatils(Booking booking)
        {
            var model = _bookings.Where(x => x.BookingId == booking.BookingId).FirstOrDefault();
            if(model != null)
            {
                model.ServiceProviderAddress = booking.ServiceProviderAddress;
                model.ServiceProviderContactNo = booking.ServiceProviderContactNo;
                model.ServiceProviderEmailId = booking.ServiceProviderEmailId;
                model.ServiceProviderName = booking.ServiceProviderName;
            }
            return Task.FromResult(model);
        }
    }
}
