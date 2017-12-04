using System.Collections.Generic;

namespace GodaddyDnsWrapper.Responses
{
    public class CloudImageListResponse
    {
        public List<CloudImageResponse> Results { get; set; }
        public PaginationResponse Pagination { get; set; }
    }
}
