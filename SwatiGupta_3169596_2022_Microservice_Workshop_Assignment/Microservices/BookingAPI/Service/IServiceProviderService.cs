using System.Threading.Tasks;

namespace BookingAPI
{
    public interface IServiceProviderService
    {
        /// <summary>
        /// Send booking request
        /// </summary>
        /// <param name="booking">The booking model</param>
        /// <returns></returns>
       Task SendBookingRequest(Booking booking);
    }
}
