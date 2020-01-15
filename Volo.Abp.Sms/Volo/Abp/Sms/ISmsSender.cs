using System.Threading.Tasks;

namespace Volo.Abp.Sms
{
    /// <summary>
    /// Sms Sender
    /// </summary>
    public interface ISmsSender
    {
        Task SendAsync(string to, string templateCode, string templateParams);

        Task SendAsync(string to, string templateCode, string templateParams, string freeSignName);

        Task SendAsync(SmsMessage sms);
    }
}