using AutoMapper;
using EventBus.Message.Event;
using NotificationAPI;

namespace BookingAPI.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BookingConfirmationEvent, BookingConfirmationDetail>()
            .ReverseMap();
        }
    }
}
