﻿using System.Threading.Tasks;

namespace BookingAPI
{
    public interface IBookingService
    {
        Task<Booking> CreateBooking(Booking booking);
    }
}
