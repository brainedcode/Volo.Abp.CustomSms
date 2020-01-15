using System;
using System.Collections.Generic;
using System.Text;

namespace Volo.Abp.Sms
{
    [Serializable]
    public class BackgroundSmsSendingJobArgs
    {
        public BackgroundSmsSendingJobArgs(string to, string templateCode, string templateParams, string signName = "")
        {
            To = to;
            TemplateCode = templateCode;
            TemplateParams = templateParams;
            SignName = signName;
        }
        public string To { get; set; }

        public string TemplateCode { get; set; }

        public string TemplateParams { get; set; }

        public string SignName { get; set; }
    }
}
