using System.ComponentModel.DataAnnotations;

namespace GodaddyDnsWrapper.Requests
{
    public class DomainRenew
    {
        [Range(1, 10)]
        public int? period { get; set; }
    }
}
