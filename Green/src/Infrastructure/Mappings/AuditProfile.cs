using AutoMapper;
using Green.Infrastructure.Models.Audit;
using Green.Application.Responses.Audit;

namespace Green.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}