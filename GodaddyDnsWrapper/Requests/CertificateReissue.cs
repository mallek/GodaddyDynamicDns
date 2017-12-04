using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GodaddyDnsWrapper.Requests
{
    public class CertificateReissue
    {
        public string csr { get; set; }
        public List<string> subjectAlternativeNames { get; set; }
        public string rootType { get; set; }
        public string callbackUrl { get; set; }
        public string commonName { get; set; }
        [Range(0, 168)]
        public int? delayExistingRevoke { get; set; }

    }
}
