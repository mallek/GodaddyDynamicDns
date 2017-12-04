using System.Collections.Generic;

namespace GodaddyDnsWrapper.Requests
{
    public class DomainAvailableBulk
    {
        public List<string> domains { get; set; }
        public string checkType { get; set; }
    }
}
