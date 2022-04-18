using AutoMapper;
using EventBus.Message.Event;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;

namespace BookingAPI
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
        public BookingController(IBookingService bookingService, IPublishEndpoint publishEndpoint, IMapper mapper)
        {
            this.bookingService = bookingService;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
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
            Console.WriteLine($"Booking request started - Booking object is - {JsonConvert.SerializeObject(bookingServiceRequest)}");
            if(bookingServiceRequest == null)
            {
                return BadRequest();
            }
            else
            {
                Console.WriteLine($"this is called locationid- { bookingServiceRequest.LocationId} - serviceid - {bookingServiceRequest.ServiceId}" );
                var booking = _mapper.Map<Booking>(bookingServiceRequest);
                var bookingOrder =  await this.bookingService.CreateBooking(booking);
                Console.WriteLine($"Booking has been confirmed and request send to service providers.Booking Id - {bookingOrder.BookingId}");
                return Accepted();
            }
        }

        [HttpPost]
        [Route("bookingresponse")]
        public async Task<ActionResult> ConfirmBookingRequest([FromBody] BookingRequestResponse bookingRequestResponse)
        {
            if(bookingRequestResponse == null)
            {
                return BadRequest();
            }
            else
            {
                if (bookingRequestResponse.IsAccepted)
                {
                    Console.WriteLine($"Is Booking accepted - {bookingRequestResponse.IsAccepted.ToString()}");
                    var eventMessage = _mapper.Map<BookingConfirmationEvent>(bookingRequestResponse);
                    await _publishEndpoint.Publish<BookingConfirmationEvent>(eventMessage);
                }
                return Accepted();
            }
        }
    }
}
