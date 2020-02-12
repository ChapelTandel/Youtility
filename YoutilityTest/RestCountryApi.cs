using System.Threading.Tasks;
using System.Web.Configuration;
using RestSharp;

namespace YoutilityTest
{
    internal class RestCountryApi
    {
        public async Task<IRestResponse> GetCapital()
        {
            var restClient = new RestClient(WebConfigurationManager.AppSettings["baseUrl"]);
            var request = new RestRequest("rest/v2/capital/london", Method.GET);
            var response = restClient.ExecuteAsync(request);
            return await response;
        }
    }
}