using System.Collections.Generic;

namespace GodaddyDnsWrapper.Responses
{
    public class DomainAvailableBulkResponse
    {
        public List<DomainAvailableResponse> Domains { get; set; }
    }
}
