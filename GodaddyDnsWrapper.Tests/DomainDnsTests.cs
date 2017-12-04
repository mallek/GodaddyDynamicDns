using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GodaddyDnsWrapper.Requests;

namespace GodaddyDnsWrapper.Tests
{
    [TestClass]
    public class DomainDnsTests
    {

        [TestMethod]
        public void GetDomainDnsRecords()
        {
            Task.Run(async () =>
            {
                // Actual test code here.
                var client = new Client(Constants.AccessKey, Constants.SecretKey);
                var results = await client.RetrieveDNSRecordsWithTypeAndName(new DNSRecordRetrieve(), Constants.Domain, null, null);
                Assert.IsTrue(results.Any());

            }).GetAwaiter().GetResult();

        }

        [TestMethod]
        public void PutDnsRecord()
        {
            Task.Run(async () =>
            {
                // Actual test code here.
                var client = new Client(Constants.AccessKey, Constants.SecretKey);
                var results = await client.ReplaceDNSRecordsWithTypeAndName(GetRecordList(), Constants.Domain, "AAAA", Constants.SubDomain);
                Assert.IsTrue(results);

            }).GetAwaiter().GetResult();

        }

        private List<DNSRecordCreateTypeName> GetRecordList()
        {
            var results = new List<DNSRecordCreateTypeName>();
            var record = new DNSRecordCreateTypeName() { data = "2701:283:4213:218d:159:c3:8082:47ba", ttl = 600 };
            results.Add(record);
            return results;
        }

        
    }
}
