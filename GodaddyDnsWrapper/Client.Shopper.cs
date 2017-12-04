using System.Threading.Tasks;
using GodaddyDnsWrapper.Helper;
using GodaddyDnsWrapper.Requests;
using GodaddyDnsWrapper.Responses;

namespace GodaddyDnsWrapper
{
    public partial class Client
    {
        /// <summary>
        /// Create a Subaccount owned by the authenticated Reseller
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ShopperIdResponse> CreateSubaccount(SubaccountCreate request)
        {
            CheckRequestValid(request);
            var client = GetBaseHttpClient();
            var response = await client.PostAsync($"shoppers/subaccount",request);
            await CheckResponseMessageIsValid(response);
            return await response.Content.ReadAsAsync<ShopperIdResponse>();
        }
        /// <summary>
        /// Get details for the specified Shopper
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ShopperResponse> RetrieveShopper(ShopperRetrieve request)
        {
            CheckRequestValid(request);
            var client = GetBaseHttpClient();
            var response = await client.GetAsync($"shoppers/{request.shopperId}");
            await CheckResponseMessageIsValid(response);
            return await response.Content.ReadAsAsync<ShopperResponse>();
        }
        /// <summary>
        /// Update details for the specified Shopper
        /// </summary>
        /// <param name="request"></param>
        /// <param name="shopperId"></param>
        /// <returns></returns>
        public async Task<ShopperIdResponse> UpdateShopper(ShopperUpdate request, string shopperId)
        {
            CheckRequestValid(request);
            var client = GetBaseHttpClient();
            var response = await client.PostAsync($"shoppers/{shopperId}", request);
            await CheckResponseMessageIsValid(response);
            return await response.Content.ReadAsAsync<ShopperIdResponse>();
        }


    }
}
