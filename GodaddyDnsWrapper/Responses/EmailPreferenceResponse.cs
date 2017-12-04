﻿namespace GodaddyDnsWrapper.Responses
{
    public class EmailPreferenceResponse
    {
        public bool? BackupCreated { get; set; }
        public bool? ServerCreated { get; set; }
        public bool? SnapshotCreated { get; set; }
        public bool? AddressChanged { get; set; }
        public bool? ServerStopped { get; set; }
        public bool? SnapshotDestroyed { get; set; }
        public bool? ServerStarted { get; set; }
        public bool? Enabled { get; set; }
        public bool? ServerDestroyed { get; set; }
    }
}
