namespace GodaddyDnsWrapper.Responses
{
    public class CartItemTrackingResponse
    {
        public string ClientIp { get; set; }
        public string ItemTrackingCode { get; set; }
        public string Pathway { get; set; }
        public CartAffiliateResponse Affiliate { get; set; }
    }
}
