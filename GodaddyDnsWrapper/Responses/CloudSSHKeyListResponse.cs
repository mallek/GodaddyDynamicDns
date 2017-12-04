using System.Collections.Generic;

namespace GodaddyDnsWrapper.Responses
{
    public class CloudSSHKeyListResponse
    {
        public List<CloudSSHKeyResponse> Results { get; set; }
        public PaginationResponse Pagination { get; set; }
    }
}
