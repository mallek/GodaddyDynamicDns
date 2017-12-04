namespace GodaddyDnsWrapper.Requests
{
    public class CloudServerVolumesRetrieve
    {
        public string serverId { get; set; }
        public string zoneId { get; set; }
        public string status { get; set; }
        public string volumeSpecId { get; set; }
        public string limit { get; set; }
        public string offset { get; set; }
    }
}
