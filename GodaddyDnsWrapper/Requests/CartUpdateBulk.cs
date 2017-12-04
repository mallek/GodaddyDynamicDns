﻿using System.Collections.Generic;

namespace GodaddyDnsWrapper.Requests
{
    public class CartUpdateBulk
    {
        public List<CartListingAdd> listings { get; set; }
        public List<CartItemUpdateBulk> items { get; set; }
        public List<CartGroupUpdateBulk> groups { get; set; }
        public List<CartDomainContacts> contacts { get; set; }
        public List<CartItemTracking> tracking { get; set; }
        public string itemSourceCode { get; set; }
        public List<BillToUpdate> billTo { get; set; }
    }
}
