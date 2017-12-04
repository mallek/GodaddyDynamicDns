using System.ComponentModel.DataAnnotations;

namespace GodaddyDnsWrapper.Requests
{
    public class OrderDetailRetrieve
    {
        [Required]
        public string orderId { get; set; }
    }
}
