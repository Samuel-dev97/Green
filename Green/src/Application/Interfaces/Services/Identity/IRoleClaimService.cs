using System.Collections.Generic;
using System.Threading.Tasks;
using Green.Application.Interfaces.Common;
using Green.Application.Requests.Identity;
using Green.Application.Responses.Identity;
using Green.Shared.Wrapper;

namespace Green.Application.Interfaces.Services.Identity
{
    public interface IRoleClaimService : IService
    {
        Task<Result<List<RoleClaimResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

        Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

        Task<Result<string>> SaveAsync(RoleClaimRequest request);

        Task<Result<string>> DeleteAsync(int id);
    }
}