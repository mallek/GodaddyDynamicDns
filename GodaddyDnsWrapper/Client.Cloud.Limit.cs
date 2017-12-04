using System.Threading.Tasks;
using GodaddyDnsWrapper.Helper;
using GodaddyDnsWrapper.Responses;

namespace GodaddyDnsWrapper
{
    public partial class Client
    {
        /// <summary>
        /// Get resource limits for your Cloud account
        /// </summary>
        /// <returns></returns>
        public async Task<CloudLimitsResponse> RetrieveAccountLimits()
        {
            var client = GetBaseHttpClient();
            var response = await client.GetAsync($"cloud/limits");
            await CheckResponseMessageIsValid(response); ;
            return await response.Content.ReadAsAsync<CloudLimitsResponse>();
        }
    }
}
