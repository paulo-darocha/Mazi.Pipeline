using System.Threading.Tasks;

namespace Mazi.Pipeline.Api.ServiceLayers;

public interface IEmailService
{
	Task SendEmail(string recipientEmail, string recipientName, string subject);
}
