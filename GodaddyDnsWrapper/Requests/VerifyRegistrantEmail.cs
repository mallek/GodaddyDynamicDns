using System.ComponentModel.DataAnnotations;

namespace GodaddyDnsWrapper.Requests
{
    public class VerifyRegistrantEmail
    {
        [Required]
        public string domain { get; set; }
    }
}
