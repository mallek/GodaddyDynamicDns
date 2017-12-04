using System.Collections.Generic;

namespace GodaddyDnsWrapper.Responses
{
    public class OrderListResponse
    {
        public List<OrderSummaryResponse> Orders { get; set; }
        public PaginationResponse pagination { get; set; }
    }
}
