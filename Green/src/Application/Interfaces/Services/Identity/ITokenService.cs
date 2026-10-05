using Green.Application.Interfaces.Common;
using Green.Application.Requests.Identity;
using Green.Application.Responses.Identity;
using Green.Shared.Wrapper;
using System.Threading.Tasks;

namespace Green.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}