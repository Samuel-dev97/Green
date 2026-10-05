using AutoMapper;
using Green.Application.Interfaces.Chat;
using Green.Application.Models.Chat;
using Green.Infrastructure.Models.Identity;

namespace Green.Infrastructure.Mappings
{
    public class ChatHistoryProfile : Profile
    {
        public ChatHistoryProfile()
        {
            CreateMap<ChatHistory<IChatUser>, ChatHistory<BlazorHeroUser>>().ReverseMap();
        }
    }
}