using Green.Application.Requests.Mail;
using System.Threading.Tasks;

namespace Green.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}