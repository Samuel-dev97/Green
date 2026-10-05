using Green.Application.Responses.Identity;
using Green.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Green.Application.Interfaces.Chat;
using Green.Application.Models.Chat;

namespace Green.Application.Interfaces.Services
{
    public interface IChatService
    {
        Task<Result<IEnumerable<ChatUserResponse>>> GetChatUsersAsync(string userId);

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> message);

        Task<Result<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string userId, string contactId);
    }
}