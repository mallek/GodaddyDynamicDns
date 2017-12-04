using System.Threading.Tasks;
using GodaddyDnsWrapper.Helper;
using GodaddyDnsWrapper.Requests;
using GodaddyDnsWrapper.Responses;

namespace GodaddyDnsWrapper
{
    public partial class Client
    {
        /// <summary>
        /// Retrieves summary country information for the provided marketId and filters
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<CountrySummaryResponse> RetrieveCountries(CountriesRetrieve request)
        {
            CheckRequestValid(request);
            var client = GetBaseHttpClient();
            var response = await client.GetAsync($"countries{QueryStringBuilder.RequestObjectToQueryString(request)}");
            await CheckResponseMessageIsValid(response);
            return await response.Content.ReadAsAsync<CountrySummaryResponse>();
        }
        /// <summary>
        /// Retrieves country and summary state information for provided countryKey
        /// </summary>
        /// <param name="request"></param>
        /// <param name="CountryKey"></param>
        /// <returns></returns>
        public async Task<CountryResponse> RetrieveCountryDetail(CountryDetailRetrieve request, string CountryKey)
        {
            CheckRequestValid(request);
            var client = GetBaseHttpClient();
            var response = await client.GetAsync($"countries/{CountryKey}{QueryStringBuilder.RequestObjectToQueryString(request)}");
            await CheckResponseMessageIsValid(response);
            return await response.Content.ReadAsAsync<CountryResponse>();
        }
    }
}
