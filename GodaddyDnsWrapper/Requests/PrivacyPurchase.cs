using System.ComponentModel.DataAnnotations;

namespace GodaddyDnsWrapper.Requests
{
    public class PrivacyPurchase
    {
        [Required]
        public Consent consent { get; set; }
    }
}
