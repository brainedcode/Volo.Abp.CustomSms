using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Settings;

namespace Volo.Abp.Sms
{
    public class SmsSenderConfiguration : ISmsSenderConfiguration
    {
        protected ISettingProvider SettingProvider { get; }
        public Task<string> GetAppKey()
        {
            return GetNotEmptySettingValueAsync(SmsSettingNames.AppKey);
        }

        public Task<string> GetAppSecret()
        {
            return GetNotEmptySettingValueAsync(SmsSettingNames.AppSecret);
        }

        public Task<string> GetDefaultFreeSignName()
        {
            return GetNotEmptySettingValueAsync(SmsSettingNames.DefaultFreeSignName);
        }

        public Task<string> GetDefaultSmsTemplateCode()
        {
            return GetNotEmptySettingValueAsync(SmsSettingNames.DefaultSmsTemplateCode);
        }

        public Task<string> GetServiceUrl()
        {
            return GetNotEmptySettingValueAsync(SmsSettingNames.ServiceUrl);
        }
        protected async Task<string> GetNotEmptySettingValueAsync(string name)
        {
            var value = await SettingProvider.GetOrNullAsync(name);

            if (value.IsNullOrEmpty())
            {
                throw new AbpException($"Setting value for '{name}' is null or empty!");
            }

            return value;
        }
    }
}
