using BookingAPI.Entities;
using BookingAPI.Service;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BookingAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        public IBookingService bookingService;
        /// <summary>
        /// Booking controller
        /// </summary>
        public BookingController(IBookingService bookingService)
        {
            this.bookingService = bookingService;
        }
        
        /// <summary>
        /// Recevice booking request
        /// </summary>
        /// <param name="bookServiceRequest"></param>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [Route("bookService")]
        public ActionResult BookServiceRequest([FromBody] BookingServiceRequest bookingServiceRequest)
        {
            if(bookingServiceRequest == null)
            {
                return BadRequest();
            }
            else
            {
                var serviceProviders = this.bookingService.GetServiceProvidersByServiceIdAndLocation(bookingServiceRequest.ServiceId, bookingServiceRequest.LocationId);
                return Accepted();
            }
        }
    }
}
