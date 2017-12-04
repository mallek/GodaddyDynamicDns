using System.Collections.Generic;

namespace GodaddyDnsWrapper.Responses
{
    public class SubscriptionBillingResponse
    {
        public string RenewAt { get; set; }
        public string Status { get; set; }
        public string Commitment { get; set; }
        public List<string> PastDueTypes { get; set; }
    }
}
