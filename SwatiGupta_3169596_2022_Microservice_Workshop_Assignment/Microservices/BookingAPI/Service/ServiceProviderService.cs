using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Polly.CircuitBreaker;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BookingAPI
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
        public async Task SendBookingRequest(Booking booking)
        {
            try
            {
                var requestURL = configuration.GetValue<string>("ServiceProviderAPIURL");

                Console.WriteLine($"service provider url - {requestURL}");

                var bookingJson = JsonConvert.SerializeObject(booking);
                var bookingRequest = new StringContent(bookingJson, Encoding.UTF8, "application/json");

                await httpClient.PostAsync($"{requestURL}/api/v1/ServiceProvider/SendBookingRequest", bookingRequest);
            }
            catch (BrokenCircuitException)
            {
                Console.WriteLine("Service provider api is currently not available");
            }
        }
    }
}
