using System.ComponentModel.DataAnnotations;

namespace GodaddyDnsWrapper.Requests
{
    public class CloudUsageRetrieve
    {
        [RegularExpression("^[A-Z][A-Z][A-Z]$")]
        public string currency { get; set; }
        public string market { get; set; }
    }
}
