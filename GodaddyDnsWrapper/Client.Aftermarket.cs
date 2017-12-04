using System.Collections.Generic;
using System.Threading.Tasks;
using GodaddyDnsWrapper.Helper;
using GodaddyDnsWrapper.Requests;
using GodaddyDnsWrapper.Responses;

namespace GodaddyDnsWrapper
{
    public partial class Client
    {

        /// <summary>
        /// Add expiry listings into GoDaddy Auction
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AftermarketListingActionResponse> AddExpiryAuction(List<AftermarketListingExpiryCreate> request)
        {
            var client = GetBaseHttpClient();
            var response = await client.PostAsync($"aftermarket/listings/expiry", request);
            await CheckResponseMessageIsValid(response);
            return await response.Content.ReadAsAsync<AftermarketListingActionResponse>();
        }

        /// <summary>
        /// Remove listings from GoDaddy Auction
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ListingActionResponse> RemoveAuctionListings(AggreementRetrieve request)
        {
            var client = GetBaseHttpClient();
            var response = await client.DeleteAsync($"aftermarket/listings{QueryStringBuilder.RequestObjectToQueryString(request)}");
            await CheckResponseMessageIsValid(response);
            return await response.Content.ReadAsAsync<ListingActionResponse>();
        }

    }
}
