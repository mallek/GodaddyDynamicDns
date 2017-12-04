using System.Collections.Generic;

namespace GodaddyDnsWrapper.Requests
{
    public class CartGroupUpdateBulk
    {
        public string groupKey { get; set; }
        public List<CartItemUpdateBulk> items { get; set; }
    }
}
