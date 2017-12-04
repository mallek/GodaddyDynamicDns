namespace GodaddyDnsWrapper.Responses
{
    public class DomainAvailableResponse
    {
        public string Domain { get; set; }
        public bool Available { get; set; }
        public bool Definitive { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public int Period { get; set; }
    }
}
