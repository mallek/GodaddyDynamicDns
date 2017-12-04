namespace GodaddyDnsWrapper.Responses
{
    public class CertificateBundleResponse
    {
        public string SerialNumber { get; set; }
        public PEMCertificatesResponse Addresses { get; set; }
    }
}
