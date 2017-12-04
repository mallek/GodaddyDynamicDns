using System.Collections.Generic;
using Newtonsoft.Json;

namespace GodaddyDnsWrapper.Responses
{
    public class CloudApplicationInputFieldResponse
    {
        public string type { get; set; }
        public string name { get; set; }
        [JsonProperty("default")]
        public string defaultVal { get; set; }
        public List<CloudApplicationInputFieldValidatorResponse> validators { get; set; }

    }
}
