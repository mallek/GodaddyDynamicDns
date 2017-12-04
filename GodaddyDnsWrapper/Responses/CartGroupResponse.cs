namespace GodaddyDnsWrapper.Responses
{
    public class CartGroupResponse
    {
        public int GroupKey { get; set; }
        public CartGroupPricingResponse Pricing { get; set; }
        public int DisplayOrder { get; set; }
        public CartGroupItemResponse Items { get; set; }

    }
}
