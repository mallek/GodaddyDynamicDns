using System.Collections.Generic;

namespace GodaddyDnsWrapper.Requests
{
    public class DomainRetrieve
    {
        public List<string> statuses { get; set; }
        public List<string> statusGroups { get; set; }
        public int limit { get; set; }
        public string marker { get; set; }
        public List<string> includes { get; set; }
        public string modifiedDate { get; set; }
    }
}
