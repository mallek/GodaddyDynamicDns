using System.Collections.Generic;

namespace GodaddyDnsWrapper.Requests
{
    public class SubscriptionRetrieve
    {
        public List<string> productGroupKeys { get; set; }
        public List<string> includes { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
        public string sort { get; set; }
    }
}
