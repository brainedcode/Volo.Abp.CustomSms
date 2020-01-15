using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System.Threading.Tasks;

namespace Volo.Abp.Sms
{
    public class NullSmsSender : SmsSenderBase
    {
        public ILogger<NullSmsSender> Logger { get; set; }

        public NullSmsSender(ISmsSenderConfiguration configuration)
           : base(configuration)
        {
            Logger = NullLogger<NullSmsSender>.Instance;
        }
        protected override Task SendSmsAsync(SmsMessage sms)
        {
            Logger.LogWarning("USING NullSmsSender!");
            Logger.LogDebug("SendSmsAsync:");
            LogSms(sms);
            return Task.FromResult(0);
        }

        private void LogSms(SmsMessage sms)
        {
            Logger.LogDebug(sms.To);
            Logger.LogDebug(sms.TemplateCode);
            Logger.LogDebug(sms.TemplateParams);
            Logger.LogDebug(sms.SignName);
        }
    }
}
