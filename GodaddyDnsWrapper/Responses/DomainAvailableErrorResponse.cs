namespace GodaddyDnsWrapper.Responses
{
    public class DomainAvailableErrorResponse
    {
        public string Code { get; set; }
        public string Domain { get; set; }
        public string Message { get; set; }
        public string Path { get; set; }
        public int Status { get; set; }
    }
}
