using System.ComponentModel.DataAnnotations;

namespace GodaddyDnsWrapper.Requests
{
    public class DNSRecordCreateType
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string data { get; set; }
        [Range(0, int.MaxValue)]
        public int? priority { get; set; }
        [Range(0, int.MaxValue)]
        public int? ttl { get; set; }
        public string service { get; set; }
        public string protocol { get; set; }
        [Range(1, 65535)]
        public int? port { get; set; }
        [Range(0, int.MaxValue)]
        public int? weight { get; set; }
    }
}
