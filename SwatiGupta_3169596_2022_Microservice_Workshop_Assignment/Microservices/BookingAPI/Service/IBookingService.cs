using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookingAPI
{
    public interface IBookingService
    {
        /// <summary>
        /// Create booking
        /// </summary>
        /// <param name="booking">The booking model</param>
        /// <returns>Return created booking order</returns>
        Task<Booking> CreateBooking(Booking booking);

        /// <summary>
        /// Get all booking list
        /// </summary>
        /// <returns>Returns booking list</returns>
        Task<IList<Booking>> GetBookings();

        /// <summary>
        /// Update service providers details
        /// </summary>
        /// <param name="bookingId">The booking model</param>
        /// <returns>Returns the updated booking obj</returns>
        Task<Booking> UpdateServiceProvidersDeatils(Booking booking);
    }
}
