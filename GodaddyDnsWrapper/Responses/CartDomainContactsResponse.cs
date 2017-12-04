namespace GodaddyDnsWrapper.Responses
{
    public class CartDomainContactsResponse
    {
        public string ContactKey { get; set; }
        public ContactResponse Registrant { get; set; }
        public ContactResponse Admin { get; set; }
        public ContactResponse Tech { get; set; }
        public ContactResponse Billing { get; set; }
        public ContactResponse Presence { get; set; }

    }
}
