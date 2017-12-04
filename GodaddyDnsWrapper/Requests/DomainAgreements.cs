using System.Collections.Generic;

namespace GodaddyDnsWrapper.Requests
{
    public class DomainAgreements
    {
        public List<string> tlds { get; set; }
        public bool privacy { get; set; }
        public bool forTransfer { get; set; }
    }
}
