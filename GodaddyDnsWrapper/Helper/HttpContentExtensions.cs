using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GodaddyDnsWrapper.Helper
{
	/// <summary>
	/// To prevent using Microsoft.AspNet.WebApi.Client package so It can support the latest .NetCore
	/// </summary>
	internal static class HttpContentExtensions
    {
        public static Task<T> ReadAsAsync<T>(this HttpContent client)
        {
            return client.ReadAsStringAsync().ContinueWith(data =>
            {
                return JsonConvert.DeserializeObject<T>(data.Result);
            });
        }

    }
}


