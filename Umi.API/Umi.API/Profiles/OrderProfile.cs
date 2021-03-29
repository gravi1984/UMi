using AutoMapper;
using Umi.API.Dtos;

namespace Umi.API.Models.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderDto>()
                // manual app Enum State => String State
                .ForMember(
                    dest => dest.State,
                    opt =>
                    {
                        opt.MapFrom(src => src.State.ToString());
                    });
        }
    }
}