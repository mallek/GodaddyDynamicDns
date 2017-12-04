namespace GodaddyDnsWrapper.Responses
{
    public class LineItemPricingResponse
    {
        public int subtotal { get; set; }
        public int List { get; set; }
        public int Savings { get; set; }
        public int Sale { get; set; }
        public int Discount { get; set; }
        public OrderFeeResponse Fees { get; set; }
        public object Unit { get; set; }
    }
}
