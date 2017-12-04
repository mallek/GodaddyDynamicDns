using System.Collections.Generic;

namespace GodaddyDnsWrapper.Responses
{
    public class SubscriptionListResponse
    {
        public List<SubscriptionResponse> Subscriptions { get; set; }
        public PaginationResponse Pagination { get; set; }
    }
}
