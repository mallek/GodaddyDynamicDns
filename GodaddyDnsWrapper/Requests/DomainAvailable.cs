using System.ComponentModel.DataAnnotations;

namespace GodaddyDnsWrapper.Requests
{
    public class DomainAvailable
    {
        //[RegularExpression(@"^[^.]{1,63}.[^.]{2,}$")]
        [Required]
        public string domain { get; set; }
        public string checkType { get; set; }
        public bool forTransfer { get; set; }
    }
}
