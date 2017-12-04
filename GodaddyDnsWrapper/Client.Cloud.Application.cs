using System.Threading.Tasks;
using GodaddyDnsWrapper.Helper;
using GodaddyDnsWrapper.Requests;
using GodaddyDnsWrapper.Responses;

namespace GodaddyDnsWrapper
{
    public partial class Client
    {
        /// <summary>
        /// Create a new application
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<CloudApplicationResponse> CreateApplication(CloudApplicationCreate request)
        {
            var client = GetBaseHttpClient();
            var response = await client.PostAsync($"cloud/applications", request);
            await CheckResponseMessageIsValid(response);
            return await response.Content.ReadAsAsync<CloudApplicationResponse>();
        }
        /// <summary>
        /// Get a list of applications
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<CloudApplicationListResponse> RetrieveApplications(CloudApplicationCreate request)
        {
            var client = GetBaseHttpClient();
            var response = await client.GetAsync($"cloud/applications{QueryStringBuilder.RequestObjectToQueryString(request)}");
            await CheckResponseMessageIsValid(response);
            return await response.Content.ReadAsAsync<CloudApplicationListResponse>();
        }
        /// <summary>
        /// Find application by applicationId
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<CloudApplicationResponse> RetrieveApplicationDetail(CloudApplicationDetailRetrieve request)
        {
            var client = GetBaseHttpClient();
            var response = await client.GetAsync($"cloud/applications/{request.applicationId}");
            await CheckResponseMessageIsValid(response);
            return await response.Content.ReadAsAsync<CloudApplicationResponse>();
        }
    }
}
