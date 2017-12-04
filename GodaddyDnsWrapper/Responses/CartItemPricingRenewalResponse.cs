namespace GodaddyDnsWrapper.Responses
{
    public class CartItemPricingRenewalResponse
    {
        public decimal Total { get; set; }
        public int? Subtotal { get; set; }
        public int List { get; set; }
        public int Savings { get; set; }
        public int Sale { get; set; }
        public int Discount { get; set; }

        public object Fees { get; set; }
        public int Taxes { get; set; }
        public double Id { get; set; }
    }
}
