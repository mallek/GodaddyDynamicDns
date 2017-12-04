using System.Collections.Generic;

namespace GodaddyDnsWrapper.Responses
{
    public class CloudSpecListResponse
    {
        public List<CloudSpecResponse> Results { get; set; }
        public PaginationResponse Pagination { get; set; }
    }
}
