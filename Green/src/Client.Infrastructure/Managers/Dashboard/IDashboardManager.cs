using Green.Shared.Wrapper;
using System.Threading.Tasks;
using Green.Application.Features.Dashboards.Queries.GetData;

namespace Green.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}