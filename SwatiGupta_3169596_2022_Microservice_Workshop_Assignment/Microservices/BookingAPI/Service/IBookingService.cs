﻿using BookingAPI.Entities;
using BookingAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookingAPI.Service
{
    public interface IBookingService
    {
        Task<Booking> CreateBooking(Booking booking);
    }
}
