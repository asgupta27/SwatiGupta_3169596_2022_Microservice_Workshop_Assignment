using Microsoft.AspNetCore.Mvc;
using ServiceProviderAPI.Entities;
using System;
using System.Collections.Generic;
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

        [HttpPost]
        [Route("SendBookingRequest")]
        public async Task<ActionResult> SendBookingRequest([FromBody] Booking booking)
        {
            Console.WriteLine($"service Id {booking.ServiceId}, locationId - {booking.LocationId}")
            await this._serviceProviderService.SendBookingRequest(booking);            
            return Ok();
        }

        [HttpPost]
        public  Task<bool> AddServiceProvider([FromBody] ServiceProvider serviceProvider)
        {
            return this._serviceProviderService.AddServiceProvider(serviceProvider);
        }
    }
}
