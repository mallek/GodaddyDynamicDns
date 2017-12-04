﻿using System.Collections.Generic;

namespace GodaddyDnsWrapper.Requests
{
    public class CloudApplicationCreate
    {
        public List<string> ports { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string version { get; set; }
        public int minimumRamMb { get; set; }
        public string changelogUrl { get; set; }
        public List<string> categories { get; set; }
        public List<CloudApplicationInputField> inputs { get; set; }
        public List<CloudApplicationLink> links { get; set; }

    }
}
