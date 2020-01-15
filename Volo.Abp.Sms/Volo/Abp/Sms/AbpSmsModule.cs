using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;
using Volo.Abp.Settings;
using Volo.Abp.VirtualFileSystem;

namespace Volo.Abp.Sms
{
    [DependsOn(
           typeof(AbpSettingsModule),
           typeof(AbpVirtualFileSystemModule),
           typeof(AbpBackgroundJobsAbstractionsModule)
           )]
    public class AbpSmsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<AbpSmsModule>();
            });
            Configure<AbpBackgroundJobOptions>(options =>
            {
                options.AddJob<BackgroundSmsSendingJob>();
            });
        }
    }
}
