using System.Threading.Tasks;
using GodaddyDnsWrapper.Helper;
using GodaddyDnsWrapper.Requests;
using GodaddyDnsWrapper.Responses;

namespace GodaddyDnsWrapper
{
    public partial class Client
    {
        /// <summary>
        /// Retrieve server usage data for a specified date range.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AccountUsageResponse> RetrieveCloudUsage(CloudUsageRetrieve request)
        {
            CheckRequestValid(request);
            var client = GetBaseHttpClient();
            var response = await client.GetAsync($"cloud/usage{QueryStringBuilder.RequestObjectToQueryString(request)}");
            await CheckResponseMessageIsValid(response);
            return await response.Content.ReadAsAsync<AccountUsageResponse>();
        }
    }
}
