using GodaddyDnsWrapper.Attributes;

namespace GodaddyDnsWrapper.Requests
{
    public class CertificateAddress
    {
        public string address1 { get; set; }
        public string postalCode { get; set; }
        [QueryStringToUpper]
        public string country { get; set; }
        public string address2 { get; set; }
        public string state { get; set; }
        public string city { get; set; }
    }
}
