using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookingAPI
{
    public interface IBookingRepository
    {
        Task<Booking> CreateBooking(Booking booking);
        Task<IList<Booking>> GetBookings();
    }
}
