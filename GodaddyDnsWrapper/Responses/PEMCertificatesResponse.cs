namespace GodaddyDnsWrapper.Responses
{
    public class PEMCertificatesResponse
    {
        public string Certificate { get; set; }
        public string Intermediate { get; set; }
        public string Root { get; set; }
        public string Cross { get; set; }
    }
}
