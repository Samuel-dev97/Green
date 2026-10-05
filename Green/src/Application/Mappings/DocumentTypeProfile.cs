using AutoMapper;
using Green.Application.Features.DocumentTypes.Commands.AddEdit;
using Green.Application.Features.DocumentTypes.Queries.GetAll;
using Green.Application.Features.DocumentTypes.Queries.GetById;
using Green.Domain.Entities.Misc;

namespace Green.Application.Mappings
{
    public class DocumentTypeProfile : Profile
    {
        public DocumentTypeProfile()
        {
            CreateMap<AddEditDocumentTypeCommand, DocumentType>().ReverseMap();
            CreateMap<GetDocumentTypeByIdResponse, DocumentType>().ReverseMap();
            CreateMap<GetAllDocumentTypesResponse, DocumentType>().ReverseMap();
        }
    }
}