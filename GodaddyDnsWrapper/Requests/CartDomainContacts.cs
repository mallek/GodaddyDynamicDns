namespace GodaddyDnsWrapper.Requests
{
    public class CartDomainContacts
    {
        public string contactKey { get; set; }
        public Contact registrant { get; set; }
        public Contact admin { get; set; }
        public Contact tech { get; set; }
        public Contact billing { get; set; }
        public Contact presence { get; set; }
    }
}
