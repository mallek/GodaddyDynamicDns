using System.Collections.Generic;

namespace GodaddyDnsWrapper.Responses
{
    public class CloudServerActionListResponse
    {
        public List<CloudServerActionResponse> Results { get; set; }
        public PaginationResponse Pagination { get; set; }
    }
}
