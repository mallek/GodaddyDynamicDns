using System.Collections.Generic;

namespace GodaddyDnsWrapper.Responses
{
    public class CloudServerUsageDetailResponse
    {
        public List<UsageDetailItemResponse> Xlarge { get; set; }
        public List<UsageDetailItemResponse> Small { get; set; }
        public List<UsageDetailItemResponse> Large { get; set; }
        public List<UsageDetailItemResponse> Tiny { get; set; }
        public List<UsageDetailItemResponse> Medium { get; set; }
    }
}
