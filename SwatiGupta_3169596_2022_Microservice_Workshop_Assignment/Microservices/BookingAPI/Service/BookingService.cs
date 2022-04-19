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
        /// <param name="booking"></param>
        /// <returns></returns>
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
        /// Get all bookings list
        /// </summary>
        /// <returns></returns>
        public Task<IList<Booking>> GetBookings()
        {
            return _bookingRepository.GetBookings();
        }
    }
}
