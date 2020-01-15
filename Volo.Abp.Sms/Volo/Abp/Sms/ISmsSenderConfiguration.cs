using System.Threading.Tasks;

namespace Volo.Abp.Sms
{
    public interface ISmsSenderConfiguration
    {
        Task<string> GetServiceUrl();
        Task<string> GetAppKey();
        Task<string> GetAppSecret();
        Task<string> GetDefaultFreeSignName();
        Task<string> GetDefaultSmsTemplateCode();
    }
}
