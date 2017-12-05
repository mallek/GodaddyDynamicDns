using Core.Common;
using GodaddyDnsWrapper.Requests;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Timers;

namespace InternalJobManager
{
    public class JobManager
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(JobManager));
        private static readonly DnsAddressCache CurrentIpV4Address = new DnsAddressCache();
        private static readonly DnsAddressCache CurrentIpV6Address = new DnsAddressCache();
        private static int _cacheCount;

        public static void RunJobs()
        {
            Timer aTimer = new Timer();
            aTimer.Elapsed += IncreaseCacheCount;
            aTimer.Elapsed += (sender, e) => CheckIpDnsEvent(AddressFamily.InterNetwork, CurrentIpV4Address);
            //If you only have ipv4 comment out the line below
            aTimer.Elapsed += (sender, e) => CheckIpDnsEvent(AddressFamily.InterNetworkV6, CurrentIpV6Address);
            aTimer.Interval = TimeSpan.FromMinutes(Constants.SyncTimeInMin).TotalMilliseconds;
            aTimer.Enabled = true;
            Log.Info($"Syncing {Constants.SubDomain}.{Constants.Domain} every {Constants.SyncTimeInMin} minute(s)");
        }

        private static void IncreaseCacheCount(object sender, ElapsedEventArgs e)
        {
            Log.Debug("Tick");
            _cacheCount++;
        }

        private static async void CheckIpDnsEvent(AddressFamily family, DnsAddressCache currentAddress)
        {
            string recordType, publicIpaddressServiceUrl;

            switch (family)
            {
                case AddressFamily.InterNetwork:
                    recordType = "A";
                    publicIpaddressServiceUrl = "http://ipv4bot.whatismyipaddress.com/";
                    break;
                case AddressFamily.InterNetworkV6:
                    recordType = "AAAA";
                    publicIpaddressServiceUrl = "http://ipv6bot.whatismyipaddress.com/";
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(family), family, null);
            }

            var client = new GodaddyDnsWrapper.Client(Constants.AccessKey, Constants.SecretKey);

            string currentIp = GetDnsAddress(publicIpaddressServiceUrl, family);
            Log.Debug($"Current {family} address: {currentIp}");

            if (string.IsNullOrEmpty(currentAddress.CurrentValue) || _cacheCount > 5)
            {
                var results = await client.RetrieveDNSRecordsWithTypeAndName(new DNSRecordRetrieve(), Constants.Domain, recordType, Constants.SubDomain).ConfigureAwait(false);
                currentAddress.CurrentValue = results.FirstOrDefault(x => x.Type == recordType)?.Data;
                _cacheCount = 0;
            }

            if (currentIp != currentAddress.CurrentValue)
            {
                Log.Info($"Updating dns records for {family}: from {currentAddress.CurrentValue}, to {currentIp}");
                var results = await client.ReplaceDNSRecordsWithTypeAndName(CreateRecord(currentIp, 600), Constants.Domain, recordType, Constants.SubDomain).ConfigureAwait(false);
                if (results)
                {
                    Log.Info($"Update Successful for {family}");
                }
                else
                {
                    Log.Error($"Update Failed for {family}");
                }
                currentAddress.CurrentValue = string.Empty;
            }

        }

        private static string GetDnsAddress(string host, AddressFamily family)
        {
            var ipclient = new RestClient(host);
            var iprequest = new RestRequest(Method.GET);
            iprequest.AddHeader("cache-control", "no-cache");
            IRestResponse ipresponse = ipclient.Execute(iprequest);
            return ValidateIpAddress(ipresponse.Content, family) ? ipresponse.Content : string.Empty;
        }

        private static bool ValidateIpAddress(string addr, AddressFamily family)
        {
            if (IPAddress.TryParse(addr, out var ip))
            {
                return ip.AddressFamily == family;
            }
            return false;
        }

        private static List<DNSRecordCreateTypeName> CreateRecord(string address, int ttl)
        {
            var results = new List<DNSRecordCreateTypeName>();
            var record = new DNSRecordCreateTypeName() { data = address, ttl = ttl };
            results.Add(record);
            return results;
        }
    }

    internal class DnsAddressCache
    {
        public string CurrentValue { get; set; }
    }
}
