using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Threading;

namespace Volo.Abp.Sms
{
    public class BackgroundSmsSendingJob: BackgroundJob<BackgroundSmsSendingJobArgs>, ITransientDependency
    {
        protected ISmsSender SmsSender { get; }
        public BackgroundSmsSendingJob(ISmsSender smsSender)
        {
            SmsSender = smsSender;
        }
        public override void Execute(BackgroundSmsSendingJobArgs args)
        {
            AsyncHelper.RunSync(() => SmsSender.SendAsync(args.To, args.TemplateCode, args.TemplateParams));
        }
    }
}
