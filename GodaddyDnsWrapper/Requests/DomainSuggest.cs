using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GodaddyDnsWrapper.Attributes;

namespace GodaddyDnsWrapper.Requests
{
    public class DomainSuggest
    {
        [Required]
        public string query { get; set; }
        [CountryAttribtue]
        [QueryStringToUpper]
        public string country { get; set; }
        public string city { get; set; }
        public List<string> sources { get; set; }
        public List<string> tlds { get; set; }
        public int? lengthMax { get; set; }
        public int? lengthMin { get; set; }
        public int? limit { get; set; }
        public int? waitMs { get; set; }
    }
}
