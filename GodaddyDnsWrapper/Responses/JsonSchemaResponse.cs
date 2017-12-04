using System.Collections.Generic;

namespace GodaddyDnsWrapper.Responses
{
    public class JsonSchemaResponse
    {
        public string Id { get; set; }
        public JsonPropertyResponse Properties { get; set; }
        public List<string> required { get; set; }
        public JsonSchemaResponse Models { get; set; }
    }
}
