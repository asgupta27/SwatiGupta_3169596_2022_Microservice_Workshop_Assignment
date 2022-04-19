using ServiceProviderAPI.Entities;
using System.Threading.Tasks;

namespace ServiceProviderAPI
{
    public interface IServiceProviderService
    {
        /// <summary>
        /// Send booking request to service providers
        /// </summary>
        /// <param name="booking"></param>
        /// <returns></returns>
       Task SendBookingRequest(Booking booking);

        /// <summary>
        /// Add service provider
        /// </summary>
        /// <param name="serviceProvider"></param>
        /// <returns>Success flag</returns>
        Task<bool> AddServiceProvider(ServiceProvider serviceProvider);
    }
}
