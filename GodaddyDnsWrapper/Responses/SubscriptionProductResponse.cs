namespace GodaddyDnsWrapper.Responses
{
    public class SubscriptionProductResponse
    {
        public int Pfid { get; set; }
        public string Label { get; set; }
        public int RenewalPfid { get; set; }
        public int RenewalPeriod { get; set; }
        public string RenewalPeriodUnit { get; set; }
        public string ProductGroupKey { get; set; }
        public bool SupportBillOn { get; set; }

    }
}
