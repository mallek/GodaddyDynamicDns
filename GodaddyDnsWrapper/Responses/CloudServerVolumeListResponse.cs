using System.Collections.Generic;

namespace GodaddyDnsWrapper.Responses
{
    public class CloudServerVolumeListResponse
    {
        public List<CloudServerVolumeResponse> Results { get; set; }
        public PaginationResponse Pagination { get; set; }
    }
}
