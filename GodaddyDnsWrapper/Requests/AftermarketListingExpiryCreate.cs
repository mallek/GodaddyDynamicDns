using System.ComponentModel.DataAnnotations;

namespace GodaddyDnsWrapper.Requests
{
    public class AftermarketListingExpiryCreate
    {
        public string domain { get; set; }
        public string expiresAt { get; set; }
        [Range(1,int.MaxValue)]
        public int losingRegistrarId { get; set; }
        public int? pageViewsMonthly { get; set; }
        public int? revenueMonthly { get; set; }
    }
}
