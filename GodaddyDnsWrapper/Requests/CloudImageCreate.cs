namespace GodaddyDnsWrapper.Requests
{
    public class CloudImageCreate
    {
        public string version { get; set; }
        public string sourceServerId { get; set; }
        public string name { get; set; }
        public string dataCenterId { get; set; }
        public string sourceImageId { get; set; }
    }
}
