using System.Threading.Tasks;
using GodaddyDnsWrapper.Helper;
using GodaddyDnsWrapper.Requests;
using GodaddyDnsWrapper.Responses;

namespace GodaddyDnsWrapper
{
    public partial class Client
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<CloudSSHKeyResponse> CreateSSHKey(CloudSSHKeyCreate request)
        {
            CheckRequestValid(request);
            var client = GetBaseHttpClient();
            var response = await client.PostAsync($"cloud/sshkeys", request);
            await CheckResponseMessageIsValid(response); ;
            return await response.Content.ReadAsAsync<CloudSSHKeyResponse>();
        }
        /// <summary>
        /// Delete a SSH key resource
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<bool> DeleteSSHKey(CloudSSHKeyDelete request)
        {
            CheckRequestValid(request);
            var client = GetBaseHttpClient();
            var response = await client.DeleteAsync($"cloud/sshkeys/{request.sshKeyId}");
            return response.IsSuccessStatusCode;
        }
        /// <summary>
        /// Get a list of SSH keys
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<CloudSSHKeyListResponse> RetreieveSSHKeys(CloudSSHKeyRetrieve request)
        {
            CheckRequestValid(request);
            var client = GetBaseHttpClient();
            var response = await client.GetAsync($"cloud/sshkeys{QueryStringBuilder.RequestObjectToQueryString(request)}");
            await CheckResponseMessageIsValid(response);
            return await response.Content.ReadAsAsync<CloudSSHKeyListResponse>();
        }
        /// <summary>
        /// Find SSH key by sshKeyId
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<CloudSSHKeyResponse> RetreieveSSHKeyDetail(CloudSSHKeyDetailRetrieve request)
        {
            CheckRequestValid(request);
            var client = GetBaseHttpClient();
            var response = await client.GetAsync($"cloud/sshkeys/{request.sshKeyId}");
            await CheckResponseMessageIsValid(response);
            return await response.Content.ReadAsAsync<CloudSSHKeyResponse>();
        }
    }
}
