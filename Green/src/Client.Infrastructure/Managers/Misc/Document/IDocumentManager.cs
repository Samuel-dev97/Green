using Green.Application.Features.Documents.Commands.AddEdit;
using Green.Application.Features.Documents.Queries.GetAll;
using Green.Application.Requests.Documents;
using Green.Shared.Wrapper;
using System.Threading.Tasks;
using Green.Application.Features.Documents.Queries.GetById;

namespace Green.Client.Infrastructure.Managers.Misc.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<GetDocumentByIdResponse>> GetByIdAsync(GetDocumentByIdQuery request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}