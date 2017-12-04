namespace GodaddyDnsWrapper.Responses
{
    public class DomainPurchaseResponse
    {
        public int OrderId { get; set; }
        public int ItemCount { get; set; }
        public decimal Total { get; set; }
        public string Currency { get; set; }
    }
}
