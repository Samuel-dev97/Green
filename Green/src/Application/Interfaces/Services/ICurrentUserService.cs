using Green.Application.Interfaces.Common;

namespace Green.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}