﻿namespace GodaddyDnsWrapper.Requests
{
    public class AbuseTicketCreate
    {
        public string type { get; set; }
        public string source { get; set; }
        public string target { get; set; }
        public string proxy { get; set; }
        public string intentional { get; set; }
        public string info { get; set; }
        public string infoUrl { get; set; }
    }
}
