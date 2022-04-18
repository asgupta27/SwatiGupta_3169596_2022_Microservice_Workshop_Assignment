
using ServiceProviderAPI.Entities;
using System.Threading.Tasks;

namespace ServiceProviderAPI
{
    public interface IServiceProviderService
    {
       Task SendBookingRequest(Booking booking);

        Task<bool> AddServiceProvider(ServiceProvider serviceProvider);
    }
}
