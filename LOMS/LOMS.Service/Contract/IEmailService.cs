using LOMS.Domain.Settings;
using System.Threading.Tasks;

namespace LOMS.Service.Contract
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}
