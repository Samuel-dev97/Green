using AutoMapper;
using Green.Application.Features.Products.Commands.AddEdit;
using Green.Domain.Entities.Catalog;

namespace Green.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}