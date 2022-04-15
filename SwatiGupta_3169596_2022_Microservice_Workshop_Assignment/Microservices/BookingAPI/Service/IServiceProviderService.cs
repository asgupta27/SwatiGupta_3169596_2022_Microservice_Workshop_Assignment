using BookingAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookingAPI.Service
{
    public interface IServiceProviderService
    {
        Task<List<ServiceProvider>> GetServiceProvidersByServiceIdAndLocation(int serviceId, int locationId);
    }
}
