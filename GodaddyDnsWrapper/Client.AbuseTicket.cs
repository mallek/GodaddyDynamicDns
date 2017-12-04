using System.Threading.Tasks;
using GodaddyDnsWrapper.Helper;
using GodaddyDnsWrapper.Requests;
using GodaddyDnsWrapper.Responses;

namespace GodaddyDnsWrapper
{
    public partial class Client
    {
        /// <summary>
        /// Create a new abuse ticket
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AbuseTicketIdResponse> CreateAbuseTicket(AbuseTicketCreate request)
        {
            var client = GetBaseHttpClient();
            var response = await client.PostAsync($"abuse/tickets", request);
            await CheckResponseMessageIsValid(response);
            return await response.Content.ReadAsAsync<AbuseTicketIdResponse>();
        }
        /// <summary>
        /// List all abuse tickets ids that match user provided filters
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AbuseTicketListResponse> RetrieveAbuseTickets(AbuseTicketRetrieve request)
        {
            var client = GetBaseHttpClient();
            var response = await client.GetAsync($"abuse/tickets{QueryStringBuilder.RequestObjectToQueryString(request)}");
            await CheckResponseMessageIsValid(response);
            return await response.Content.ReadAsAsync<AbuseTicketListResponse>();
        }

        /// <summary>
        /// Return the abuse ticket data for a given ticket id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AbuseTicketResponse> RetrieveAbuseTicketDetail(AbuseTicketDetailRetrieve request)
        {
            var client = GetBaseHttpClient();
            var response = await client.GetAsync($"abuse/tickets/{request.ticketId}");
            await CheckResponseMessageIsValid(response);
            return await response.Content.ReadAsAsync<AbuseTicketResponse>();
        }

    }
}
