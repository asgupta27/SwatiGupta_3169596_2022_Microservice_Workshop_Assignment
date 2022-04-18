﻿using BookingAPI.Entities;
using BookingAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookingAPI.Service
{
    public interface IServiceProviderService
    {
       Task SendBookingRequest(Booking booking);
    }
}
