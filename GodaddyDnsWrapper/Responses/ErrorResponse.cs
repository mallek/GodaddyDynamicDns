using System.Collections.Generic;

namespace GodaddyDnsWrapper.Responses
{
    public class ErrorResponse
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public List<ErrorFieldResponse> Fields { get; set; }
    }
}
