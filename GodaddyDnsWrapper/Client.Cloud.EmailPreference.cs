using System.Threading.Tasks;
using GodaddyDnsWrapper.Helper;
using GodaddyDnsWrapper.Requests;
using GodaddyDnsWrapper.Responses;

namespace GodaddyDnsWrapper
{
    public partial class Client
    {
        /// <summary>
        /// Get the email preferences for the user.
        /// </summary>
        /// <returns></returns>
        public async Task<EmailPreferenceResponse> RetrieveEmailPreference()
        {
            var client = GetBaseHttpClient();
            var response = await client.GetAsync($"cloud/emailpreferences");
            await CheckResponseMessageIsValid(response);
            return await response.Content.ReadAsAsync<EmailPreferenceResponse>();
        }
        /// <summary>
        /// Update the user's email preferences
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<EmailPreferenceResponse> UpdateEmailPreference(EmailPreferenceRetrieve request)
        {
            CheckRequestValid(request);
            var client = GetBaseHttpClient();
            var response = await client.PatchAsync($"cloud/emailpreferences", request);
            await CheckResponseMessageIsValid(response);
            return await response.Content.ReadAsAsync<EmailPreferenceResponse>();
        }
    }
}
