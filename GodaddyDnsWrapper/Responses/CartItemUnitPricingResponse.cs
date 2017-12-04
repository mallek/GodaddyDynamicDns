using System.Collections.Generic;

namespace GodaddyDnsWrapper.Responses
{
    public class CartItemUnitPricingResponse
    {
        public int List { get; set; }
        public int Subtotal { get; set; }
        public int Savings { get; set; }
        public int Sale { get; set; }
        public int Discount { get; set; }
        public CartFeeResponse Fees { get; set; }
        public List<CartItemUnitPricingRangeResponse> Ranges { get; set; }
    }
}
