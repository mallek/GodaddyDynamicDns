using System.Collections.Generic;

namespace GodaddyDnsWrapper.Requests
{
    public class DomainUpdate
    {
        public bool locked { get; set; }
        public List<object> nameServers { get; set; }
        public bool renewAuto { get; set; }
        public string subaccountId { get; set; }
    }
}
