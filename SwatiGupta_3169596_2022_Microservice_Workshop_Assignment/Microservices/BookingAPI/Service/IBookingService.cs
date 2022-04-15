using BookingAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookingAPI.Service
{
    public interface IBookingService
    {
        Task GetServiceProvidersByServiceIdAndLocation(int serviceId, int locationId);
    }
}
