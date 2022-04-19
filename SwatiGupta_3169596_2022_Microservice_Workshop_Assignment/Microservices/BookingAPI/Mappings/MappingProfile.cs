using AutoMapper;
using EventBus.Message.Event;

namespace BookingAPI.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BookingServiceRequest, Booking>()
            .ForMember(dest => dest.BookingId, opt => opt.MapFrom(src => src.Id))
            .ReverseMap();

            CreateMap<BookingRequestResponse, BookingConfirmationEvent>()
            .ReverseMap();

            CreateMap<BookingRequestResponse, Booking>()
           .ReverseMap();
        }
    }
}
