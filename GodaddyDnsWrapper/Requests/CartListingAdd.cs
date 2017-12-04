using System;

namespace GodaddyDnsWrapper.Requests
{
    public class CartListingAdd
    {
        public string listingId { get; set; }
        public int? quantity { get; set; }
        public double? periodCount { get; set; }
        public DateTime? billOn { get; set; }
        public CartItemCoupon coupon { get; set; }
        public object metadata { get; set; }
    }
}
