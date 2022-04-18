using BookingAPI.Entities;
using System.Threading.Tasks;

namespace BookingAPI.Repositories
{
    public interface IBookingRepository
    {
        Task<Booking> CreateBooking(Booking booking);
    }
}
