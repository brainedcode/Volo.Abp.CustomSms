namespace Volo.Abp.Sms
{
    /// <summary>
    /// Sms Message
    /// </summary>
    public class SmsMessage
    {
        public SmsMessage(string to, string templateCode, string templateParams, string signName = "")
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