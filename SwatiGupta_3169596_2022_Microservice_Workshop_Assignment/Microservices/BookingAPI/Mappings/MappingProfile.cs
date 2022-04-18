using AutoMapper;

namespace BookingAPI.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BookingServiceRequest, Booking>()
            .ForMember(dest => dest.BookingId, opt => opt.MapFrom(src => src.Id))
            .ReverseMap();
        }
    }
}
