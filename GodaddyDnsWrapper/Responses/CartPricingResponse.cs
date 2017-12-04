﻿namespace GodaddyDnsWrapper.Responses
{
    public class CartPricingResponse
    {
        public decimal Total { get; set; }
        public int subtotal { get; set; }
        public int List { get; set; }
        public int Savings { get; set; }
        public int Discount { get; set; }
        public int Taxes { get; set; }
        public CartFeeResponse Fees { get; set; }
    }
}
