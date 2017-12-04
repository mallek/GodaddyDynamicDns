using System.Collections.Generic;

namespace GodaddyDnsWrapper.Requests
{
    public class CloudImagePublicationCreate
    {
        public List<string> dataCenterIds { get; set; }
        public string applicationId { get; set; }
    }
}
