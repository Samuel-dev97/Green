using AutoMapper;
using Green.Application.Features.Documents.Commands.AddEdit;
using Green.Application.Features.Documents.Queries.GetById;
using Green.Domain.Entities.Misc;

namespace Green.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
            CreateMap<GetDocumentByIdResponse, Document>().ReverseMap();
        }
    }
}