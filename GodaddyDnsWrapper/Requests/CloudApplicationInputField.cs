using System.Collections.Generic;
using Newtonsoft.Json;

namespace GodaddyDnsWrapper.Requests
{
    public class CloudApplicationInputField
    {
        public string type { get; set; }
        public string name { get; set; }
        [JsonProperty("default")]
        public string defaultVal { get; set; }
        public List<CloudApplicationInputFieldValidator> validators { get; set; }

    }
}
