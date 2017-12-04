using System;

namespace Core.Common
{
    public static class Constants
    {
        public static string AccessKey =>
            Environment.GetEnvironmentVariable("AccessKey", EnvironmentVariableTarget.Machine) ?? "Cannot Find Access Key Environment Variable";

        public static string SecretKey =>
            Environment.GetEnvironmentVariable("SecretKey", EnvironmentVariableTarget.Machine) ?? "Cannot Find Secret Key Environment Variable";

        public static string Domain => 
            Environment.GetEnvironmentVariable("SyncDomain", EnvironmentVariableTarget.Machine) ?? "Cannot find domain Environment Variable";

        public static string SubDomain => "home";

        public static int SyncTimeInMin => 60;
    }
}
