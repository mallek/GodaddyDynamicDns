using System.Collections.Generic;

namespace GodaddyDnsWrapper.Responses
{
    public class CloudDataCenterListResponse
    {
        public List<CloudDataCenterResponse> Resulsts { get; set; }
        public PaginationResponse Pagination { get; set; }
    }
}
