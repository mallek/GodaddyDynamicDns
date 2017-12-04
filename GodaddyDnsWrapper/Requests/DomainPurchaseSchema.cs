using System.ComponentModel.DataAnnotations;

namespace GodaddyDnsWrapper.Requests
{
    public class DomainPurchaseSchema
    {
        [Required]
        public string tld { get; set; }
    }
}
