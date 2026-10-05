using AutoMapper;
using Green.Infrastructure.Models.Identity;
using Green.Application.Responses.Identity;

namespace Green.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, BlazorHeroRole>().ReverseMap();
        }
    }
}