using System.Threading.Tasks;

namespace BookingAPI
{
    public interface IServiceProviderService
    {
       Task SendBookingRequest(Booking booking);
    }
}
