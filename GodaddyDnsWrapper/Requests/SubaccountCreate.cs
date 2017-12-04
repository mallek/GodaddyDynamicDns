using System.ComponentModel.DataAnnotations;

namespace GodaddyDnsWrapper.Requests
{
    public class SubaccountCreate
    {
        [EmailAddress]
        public string email { get; set; }
        public string password { get; set; }
        public string nameFirst { get; set; }
        public string nameLast { get; set; }
        public int externalId { get; set; }
        public string marketId { get; set; }
    }
}
