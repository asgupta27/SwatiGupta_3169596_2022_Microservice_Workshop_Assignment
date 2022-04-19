using Microsoft.AspNetCore.Mvc;
using ServiceProviderAPI.Entities;
using System.Threading.Tasks;

namespace ServiceProviderAPI
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ServiceProviderController : ControllerBase
    {
        public IServiceProviderService _serviceProviderService;
        public ServiceProviderController(IServiceProviderService serviceProviderService)
        {
            this._serviceProviderService = serviceProviderService;
        }

        /// <summary>
        /// Send booking request to service providers
        /// </summary>
        /// <param name="booking">The booking model</param>
        /// <returns></returns>
        [HttpPost]
        [Route("SendBookingRequest")]
        public async Task<ActionResult> SendBookingRequest([FromBody] Booking booking)
        {
            await this._serviceProviderService.SendBookingRequest(booking);            
            return Ok();
        }

        /// <summary>
        /// Add service provider
        /// </summary>
        /// <param name="serviceProvider">The service provider</param>
        /// <returns>Return the success flag</returns>
        [HttpPost]
        public  Task<bool> AddServiceProvider([FromBody] ServiceProvider serviceProvider)
        {
            return this._serviceProviderService.AddServiceProvider(serviceProvider);
        }
    }
}
