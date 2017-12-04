namespace GodaddyDnsWrapper.Responses
{
    public class CloudLimitsResponse
    {
        public CloudLimitResponse Servers { get; set; }
        public CloudLimitResponse Addresses { get; set; }
        public CloudLimitResponse VolumeGb { get; set; }
        public CloudLimitResponse Snapshots { get; set; }
        public CloudLimitResponse Keys { get; set; }

    }
}
