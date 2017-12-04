namespace GodaddyDnsWrapper.Responses
{
    public class CartItemPricingResponse
    {
        public int Subtotal { get; set; }
        public int List { get; set; }
        public int Savings { get; set; }
        public int Sale { get; set; }
        public int Discount { get; set; }
        public CartFeeResponse Fees { get; set; }
        public CartItemUnitPricingResponse Unit { get; set; }
        public CartItemPricingRenewalResponse Renewal { get; set; }
    }
}
