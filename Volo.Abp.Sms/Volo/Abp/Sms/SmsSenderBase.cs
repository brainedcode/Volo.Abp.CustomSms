using System.Threading.Tasks;

namespace Volo.Abp.Sms
{
    public abstract class SmsSenderBase : ISmsSender
    {
        protected ISmsSenderConfiguration _configuration = null;
        protected SmsSenderBase(ISmsSenderConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendAsync(string to, string templateCode, string templateParams)
        {
            await SendSmsAsync(new SmsMessage(to, templateCode, templateParams,await _configuration.GetDefaultFreeSignName()));
        }

        public async Task SendAsync(string to, string templateCode, string templateParams, string freeSignName)
        {
            await SendSmsAsync(new SmsMessage(to, templateCode, templateParams, freeSignName));
        }
        protected abstract Task SendSmsAsync(SmsMessage sms);

        public async Task SendAsync(SmsMessage sms)
        {
            await SendSmsAsync(sms);
        }
    }

}
