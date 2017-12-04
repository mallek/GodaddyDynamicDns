using System.ComponentModel.DataAnnotations;

namespace GodaddyDnsWrapper.Requests
{
    public class DomainTransferIn
    {
        [Required]
        public string authCode { get; set; }
        [Range(1, 10)]
        public int? period { get; set; }
        public bool? renewAuto { get; set; }
        public bool? privacy { get; set; }
        public Consent consent{ get; set; }
    }
}
