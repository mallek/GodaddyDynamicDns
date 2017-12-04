using System.Collections.Generic;

namespace GodaddyDnsWrapper.Responses
{
    public class DiscountDetailResponse
    {
        public List<DiscountDetailItemResponse> Servers { get; set; }
        public List<DiscountDetailItemResponse> Addresses { get; set; }
    }
}
