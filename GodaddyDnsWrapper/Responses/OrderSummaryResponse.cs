using System.Collections.Generic;

namespace GodaddyDnsWrapper.Responses
{
    public class OrderSummaryResponse
    {
        public int OrderId { get; set; }
        public string ParentOrderId { get; set; }
        public string Currency { get; set; }
        public string CreatedAt { get; set; }
        public OrderSummaryPricingResponse Pricing { get; set; }
        public List<LineItemSummaryResponse> Items { get; set; }
    }
}
