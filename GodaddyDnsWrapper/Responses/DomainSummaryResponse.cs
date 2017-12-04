﻿using System;
using System.Collections.Generic;

namespace GodaddyDnsWrapper.Responses
{
    public class DomainSummaryResponse
    {
        public int DomainId { get; set; }
        public string Domain { get; set; }
        public string Status { get; set; }
        public DateTime Expires { get; set; }
        public bool ExpirationProtected { get; set; }
        public bool HoldRegistrar { get; set; }
        public bool Locked { get; set; }
        public bool Privacy { get; set; }
        public bool RenewAuto { get; set; }
        public bool Renewable { get; set; }
        public DateTime RenewDeadline { get; set; }
        public bool TransferProtected { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public string AuthCode { get; set; }
        public List<string> NameServers { get; set; }
        public ContactResponse ContactRegistrant { get; set; }
        public ContactResponse ContactBilling { get; set; }
        public ContactResponse ContactAdmin { get; set; }
        public ContactResponse ContactTech { get; set; }
    }
}
