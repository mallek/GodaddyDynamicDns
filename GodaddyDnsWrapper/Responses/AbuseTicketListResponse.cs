using System.Collections.Generic;

namespace GodaddyDnsWrapper.Responses
{
    public class AbuseTicketListResponse
    {
        public List<string> TicketIds { get; set; }
        public PaginationResponse Pagination { get; set; }
    }
}
