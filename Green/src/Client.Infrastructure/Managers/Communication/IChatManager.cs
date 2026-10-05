using Green.Application.Models.Chat;
using Green.Application.Responses.Identity;
using Green.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Green.Application.Interfaces.Chat;

namespace Green.Client.Infrastructure.Managers.Communication
{
    public interface IChatManager : IManager
    {
        Task<IResult<IEnumerable<ChatUserResponse>>> GetChatUsersAsync();

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> chatHistory);

        Task<IResult<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string cId);
    }
}