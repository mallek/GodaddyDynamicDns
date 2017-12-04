using System.ComponentModel.DataAnnotations;
using GodaddyDnsWrapper.Attributes;

namespace GodaddyDnsWrapper.Requests
{
    public class Address
    {
        [MinLength(1)]
        [MaxLength(41)]
        public string address1 { get; set; }
        [MaxLength(41)]
        public string address2 { get; set; }
        [MinLength(1)]
        [MaxLength(30)]
        public string city { get; set; }
        [MinLength(1)]
        [MaxLength(30)]
        public string state { get; set; }
        [MinLength(1)]
        [MaxLength(10)]
        public string postalCode { get; set; }
        [CountryAttribtue]
        [QueryStringToUpper]
        public string country { get; set; }
    }
}
