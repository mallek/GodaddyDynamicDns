using System.Collections.Generic;

namespace GodaddyDnsWrapper.Responses
{
    public class CountryResponse
    {
        public string CountryKey { get; set; }
        public string Label { get; set; }
        public string CallingCode { get; set; }
        public List<StateResponse> States { get; set; }
    }
}
