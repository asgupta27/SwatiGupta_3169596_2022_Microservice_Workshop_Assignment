using BookingAPI.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BookingAPI.Service
{
    public class BookingService : IBookingService
    {
        public IServiceProviderService serviceProviderService;
        public BookingService(IServiceProviderService serviceProviderService)
        {
            this.serviceProviderService = serviceProviderService;
        }
        public async Task  GetServiceProvidersByServiceIdAndLocation(int serviceId, int locationId)
        {
            var sps = serviceProviderService.GetServiceProvidersByServiceIdAndLocation(serviceId, locationId);

        }
    }
}
