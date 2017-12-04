using System;

namespace GodaddyDnsWrapper.Requests
{
    public class CartItemUpdateBulk
    {
        public int? itemId { get; set; }
        public int? pfid { get; set; }
        public int? subscriptionId { get; set; }
        public int? quantity { get; set; }
        public int? periodCount { get; set; }
        public DateTime? billOn { get; set; }
        public CartItemCoupon coupon { get; set; }
        public object metadata { get; set; }
        public TamperSignature signature { get; set; }
    }
}
