namespace GodaddyDnsWrapper.Responses
{
    public class CloudSSHKeyResponse
    {
        public string Fingerprint { get; set; }
        public string Name { get; set; }
        public string SshKeyId { get; set; }
        public string CreatedAt { get; set; }
        public string ModifiedAt { get; set; }
    }
}
