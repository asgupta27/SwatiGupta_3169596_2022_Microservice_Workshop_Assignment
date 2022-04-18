using ServiceProviderAPI.Entities;
using System;
using System.Threading.Tasks;

namespace ServiceProviderAPI
{
    public class ServiceProviderService : IServiceProviderService
    {
        public IServiceProviderRepository _serviceProviderRepository;

        public ServiceProviderService(IServiceProviderRepository serviceProviderRepository)
        {
            _serviceProviderRepository = serviceProviderRepository;
        }
        public async Task SendBookingRequest(Booking booking)
        {
            var serviceProviders = _serviceProviderRepository.GetServiceProvidersByServiceAndLocation(booking.ServiceId, booking.LocationId);
            if(serviceProviders != null)
            {
                foreach(var provider in serviceProviders)
                {
                    Console.WriteLine($"Dear {provider.Name} ,Booking for service Id {booking.ServiceId} is request - you can confirm or reject this booking. Booking Id - {booking.BookingId}, ");
                }
            }
        }
        public Task<bool> AddServiceProvider(ServiceProvider serviceProvider)
        {
            return _serviceProviderRepository.AddServiceProvider(serviceProvider);
        }
    }
}
