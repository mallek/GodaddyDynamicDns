using System.ComponentModel.DataAnnotations;

namespace GodaddyDnsWrapper.Requests
{
    public class CountriesRetrieve
    {
        [Required]
        public int MarketId { get; set; }
        public int RegionTypeId { get; set; }
        public string RegionName { get; set; }
        public string Sort { get; set; }
        public string Order { get; set; }
    }
}
