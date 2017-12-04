namespace GodaddyDnsWrapper.Requests
{
    public class CloudServerRetrieve
    {
        public string status { get; set; }
        public bool backupsEnabled { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
    }
}
