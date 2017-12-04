using System.Collections.Generic;

namespace GodaddyDnsWrapper.Responses
{
    public class CloudServerListResponse
    {
        public List<CloudServerResponse> Results { get; set; }
        public PaginationResponse Pagination { get; set; }
    }
}
