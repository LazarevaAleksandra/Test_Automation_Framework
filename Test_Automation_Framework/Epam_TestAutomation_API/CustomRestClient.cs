using Microsoft.Extensions.Configuration;
using RestSharp;

namespace Epam_TestAutomation_API
{
    public class CustomRestClient
    {
        public readonly Configuration _apiConfig = new();

        public CustomRestClient()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            config.Bind(_apiConfig);
        }

        public RestClient CreateRestClient(Service service)
        {
            var baseUrl = service switch
            {
                Service.Bibles => _apiConfig.BiblesBaseUrl,
                Service.Phones => _apiConfig.PhonesBaseUrl,
                _ => throw new ArgumentException("Invalid service option provided!")
            };

            var options = new RestClientOptions()
            {
                BaseUrl = baseUrl,
            };

            return new RestClient(options);
        }
    }
}
