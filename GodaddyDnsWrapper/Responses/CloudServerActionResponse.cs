namespace GodaddyDnsWrapper.Responses
{
    public class CloudServerActionResponse
    {
        public string Status { get; set; }
        public string ServerActionId { get; set; }
        public bool CreatedAt { get; set; }
        public string ModifiedAt { get; set; }
        public string Type { get; set; }
        public string CompletedAt { get; set; }
        public string ServerId { get; set; }
    }
}
