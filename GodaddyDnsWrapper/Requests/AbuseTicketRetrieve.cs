using System;

namespace GodaddyDnsWrapper.Requests
{
    public class AbuseTicketRetrieve
    {
        public string type { get; set; }
        public bool closed { get; set; }
        public string sourceDomainOrIp { get; set; }
        public string target { get; set; }
        public DateTime createdStart { get; set; }
        public DateTime createdEnd { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
    }
}
