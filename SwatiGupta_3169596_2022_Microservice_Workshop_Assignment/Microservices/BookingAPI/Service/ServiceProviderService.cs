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
    public class ServiceProviderService : IServiceProviderService
    {
        private readonly HttpClient httpClient;
        private readonly IConfiguration configuration;
        public ServiceProviderService(HttpClient httpClient, IConfiguration configuration)
        {
            this.httpClient = httpClient;
            this.configuration = configuration;
        }
        public async Task<List<ServiceProvider>>  GetServiceProvidersByServiceIdAndLocation(int serviceId, int locationId)
        {
            var requestURL = configuration.GetValue<string>("ServiceProviderAPIURL");

            return await httpClient.GetFromJsonAsync<List<ServiceProvider>>($"{requestURL}/ServiceProvider?serviceId={serviceId}&locationId={locationId}");
        }
    }
}
