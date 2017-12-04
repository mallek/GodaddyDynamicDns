using System.Collections.Generic;

namespace GodaddyDnsWrapper.Responses
{
    public class CloudZoneListResponse
    {
        public List<CloudZoneResponse> Resulsts { get; set; }
        public PaginationResponse Pagination { get; set; }
    }
}
