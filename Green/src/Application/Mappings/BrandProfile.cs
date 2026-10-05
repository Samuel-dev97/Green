using AutoMapper;
using Green.Application.Features.Brands.Commands.AddEdit;
using Green.Application.Features.Brands.Queries.GetAll;
using Green.Application.Features.Brands.Queries.GetById;
using Green.Domain.Entities.Catalog;

namespace Green.Application.Mappings
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<AddEditBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsResponse, Brand>().ReverseMap();
        }
    }
}