using AutoMapper;
using BookingAPI.Entities;
using BookingAPI.Service;
using EventBus.Message.Event;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace BookingAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        public IBookingService bookingService;
        private readonly IPublishEndpoint _publishEndpoint;
        private readonly IMapper _mapper;
        /// <summary>
        /// Booking controller
        /// </summary>
        public BookingController(IBookingService bookingService, IPublishEndpoint publishEndpoint)
        {
            this.bookingService = bookingService;
            _publishEndpoint = publishEndpoint ?? throw new ArgumentNullException(nameof(publishEndpoint));
        }
        
        /// <summary>
        /// Recevice booking request
        /// </summary>
        /// <param name="bookServiceRequest"></param>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [Route("bookService")]
        public async Task<ActionResult> BookServiceRequest([FromBody] BookingServiceRequest bookingServiceRequest)
        {
            Console.WriteLine("this is called");
            if(bookingServiceRequest == null)
            {
                return BadRequest();
            }
            else
            {
                Console.WriteLine($"this is called locationid- { bookingServiceRequest.LocationId} - serviceid - {bookingServiceRequest.ServiceId}" );
                var serviceProviders =  this.bookingService.GetServiceProvidersByServiceIdAndLocation(bookingServiceRequest.ServiceId, bookingServiceRequest.LocationId).Result;
                if(serviceProviders != null && serviceProviders.Count > 0)
                {
                    Console.WriteLine("The data in service provider exists");
                }
                foreach(var serviceProvider in serviceProviders)
                {
                    var eventMessage = _mapper.Map<BookingServiceRequestEvent>(bookingServiceRequest);
                  
                    await _publishEndpoint.Publish<BookingServiceRequestEvent>(eventMessage);
                }
                return Ok(serviceProviders);
            }
        }
    }
}
