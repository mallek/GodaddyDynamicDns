using System.Collections.Generic;

namespace GodaddyDnsWrapper.Responses
{
    public class CloudAddressListResponse
    {
        public List<CloudIpAddressResponse> Results { get; set; }
        public PaginationResponse Pagination { get; set; }
    }
}
