using System.Threading.Tasks;
using GodaddyDnsWrapper.Helper;
using GodaddyDnsWrapper.Requests;
using GodaddyDnsWrapper.Responses;

namespace GodaddyDnsWrapper
{
    public partial class Client
    {
        /// <summary>
        /// Get a list of specs
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<CloudSpecListResponse> RetrieveCloudSpecs(CloudSpecsRetrieve request)
        {
            CheckRequestValid(request);
            var client = GetBaseHttpClient();
            var response = await client.GetAsync($"cloud/specs{QueryStringBuilder.RequestObjectToQueryString(request)}");
            await CheckResponseMessageIsValid(response);
            return await response.Content.ReadAsAsync<CloudSpecListResponse>();
        }
        /// <summary>
        /// Find spec by spec specId
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<CloudSpecResponse> RetrieveCloudSpecsDetail(CloudSpecsDetailRetrieve request)
        {
            CheckRequestValid(request);
            var client = GetBaseHttpClient();
            var response = await client.GetAsync($"cloud/specs/{request.specId}");
            await CheckResponseMessageIsValid(response);
            return await response.Content.ReadAsAsync<CloudSpecResponse>();
        }

    }
}
