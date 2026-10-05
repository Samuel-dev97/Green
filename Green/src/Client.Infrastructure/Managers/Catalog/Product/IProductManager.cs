using Green.Application.Features.Products.Commands.AddEdit;
using Green.Application.Features.Products.Queries.GetAllPaged;
using Green.Application.Requests.Catalog;
using Green.Shared.Wrapper;
using System.Threading.Tasks;

namespace Green.Client.Infrastructure.Managers.Catalog.Product
{
    public interface IProductManager : IManager
    {
        Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request);

        Task<IResult<string>> GetProductImageAsync(int id);

        Task<IResult<int>> SaveAsync(AddEditProductCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}