using BookingAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookingAPI.Service
{
    public interface IBookingService
    {
        Task<List<ServiceProvider>> GetServiceProvidersByServiceIdAndLocation(int serviceId, int locationId);
    }
}
