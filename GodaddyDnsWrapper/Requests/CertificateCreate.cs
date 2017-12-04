using System.Collections.Generic;

namespace GodaddyDnsWrapper.Requests
{
    public class CertificateCreate
    {
        public string csr { get; set; }
        public string productType { get; set; }
        public int period { get; set; }
        public CertificateContact contact { get; set; }
        public string commonName { get; set; }
        public List<string> subjectAlternativeNames { get; set; }
        public string slotSize { get; set; }
        public string callbackUrl { get; set; }
        public string rootType { get; set; }
        public bool intelVPro { get; set; }
        public CertificateOrganizationCreate organization { get; set; }


    }
}
