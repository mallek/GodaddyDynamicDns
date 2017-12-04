using Newtonsoft.Json;

namespace GodaddyDnsWrapper.Responses
{
    public class JsonDataTypeResponse
    {
        public string Type { get; set; }
        [JsonProperty("$ref")]
        public string RefVal { get; set; }
        public string Format { get; set; }
        public string Pattern { get; set; }
    }
}
