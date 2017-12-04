using System.ComponentModel.DataAnnotations;

namespace GodaddyDnsWrapper.Requests
{
    public class PrivacyDelete
    {
        [Required]
        public string domain { get; set; }
    }
}
