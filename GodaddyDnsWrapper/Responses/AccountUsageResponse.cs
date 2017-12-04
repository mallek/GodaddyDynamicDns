namespace GodaddyDnsWrapper.Responses
{
    public class AccountUsageResponse
    {
        public CloudServerUsageDetailResponse Servers { get; set; }
        public UsageSummaryResponse Summary { get; set; }
        public DiscountDetailResponse Discounts { get; set; }
        public AddressUsageDetailResponse Addresses { get; set; }
    }
}
