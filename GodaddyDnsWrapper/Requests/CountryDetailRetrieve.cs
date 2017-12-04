using System.ComponentModel.DataAnnotations;

namespace GodaddyDnsWrapper.Requests
{
    public class CountryDetailRetrieve
    {
        [Required]
        public int MarketId { get; set; }
        public string Sort { get; set; }
        public string Order { get; set; }
    }
}
