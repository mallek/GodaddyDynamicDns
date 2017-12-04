using System.ComponentModel.DataAnnotations;

namespace GodaddyDnsWrapper.Requests
{
    public class DNSRecordRetrieve
    {
        [Required]
        [Range(0, int.MaxValue)]
        public int offset { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int limit { get; set; }
    }
}
