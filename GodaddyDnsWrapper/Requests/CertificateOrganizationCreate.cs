namespace GodaddyDnsWrapper.Requests
{
    public class CertificateOrganizationCreate
    {
        public string name { get; set; }
        public CertificateAddress address { get; set; }
        public string phone { get; set; }
        public string assumedName { get; set; }
        public string registrationNumber { get; set; }
        public string registrationAgent { get; set; }
    }
}
