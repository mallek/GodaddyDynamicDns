using System.Collections.Generic;

namespace GodaddyDnsWrapper.Responses
{
    public class SubscriptionRelationsResponse
    {
        public string Parent { get; set; }
        public List<string> Children { get; set; }
    }
}
