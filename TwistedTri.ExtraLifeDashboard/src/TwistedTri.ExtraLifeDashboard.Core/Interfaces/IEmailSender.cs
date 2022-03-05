using System.Threading.Tasks;

namespace TwistedTri.ExtraLifeDashboard.Core.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string to, string from, string subject, string body);
    }
}