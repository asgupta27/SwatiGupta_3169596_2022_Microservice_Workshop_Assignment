using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookingAPI
{
    public class BookingService : IBookingService
    {
        public IBookingRepository _bookingRepository;
        public IServiceProviderService _serviceProviderService;
        public BookingService(IBookingRepository bookingRepository, IServiceProviderService serviceProviderService)
        {
            _bookingRepository = bookingRepository;
            _serviceProviderService = serviceProviderService;
        }

        /// <summary>
        /// Create booking
        /// </summary>
        /// <param name="booking">The booking model</param>
        /// <returns>Return created booking order</returns>
        public Task<Booking> CreateBooking(Booking booking)
        {            
            var bookingObj = _bookingRepository.CreateBooking(booking);
            if(bookingObj != null)
            {
                _serviceProviderService.SendBookingRequest(booking);
            }
            return bookingObj;
        }

        /// <summary>
        /// Get all booking list
        /// </summary>
        /// <returns>Returns booking list</returns>
        public Task<IList<Booking>> GetBookings()
        {
            return _bookingRepository.GetBookings();
        }

        /// <summary>
        /// Update service providers details
        /// </summary>
        /// <param name="bookingId">The booking model</param>
        /// <returns>Returns the updated booking obj</returns>
        public Task<Booking> UpdateServiceProvidersDeatils(Booking booking)
        {
            return _bookingRepository.UpdateServiceProvidersDeatils(booking);
        }
    }
}
