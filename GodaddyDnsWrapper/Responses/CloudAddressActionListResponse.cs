using System.Collections.Generic;

namespace GodaddyDnsWrapper.Responses
{
    public class CloudAddressActionListResponse
    {
        public List<CloudAddressActionResponse> Results { get; set; }
        public PaginationResponse Pagination { get; set; }
    }
}
