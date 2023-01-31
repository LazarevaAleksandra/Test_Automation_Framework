using RestSharp;

namespace Epam_TestAutomation_API.Controllers
{
    public class BiblesController : BaseController
    {
        public BiblesController(CustomRestClient client, string apiKey = "") : base(client, Service.Bibles, apiKey) {}

        public BiblesController(CustomRestClient client) : base(client, Service.Bibles, client._apiConfig.ApiKey) {}

        private const string BiblesResource = "/v1/bibles";     
        private const string AudioBiblesResource = "/v1/audio-bibles";
        private const string SingleAudioBiblesResource = "/v1/audio-bibles/{0}";

        public (RestResponse Response, T? Bibles) GetBibles<T>()
        {
            return Get<T>(BiblesResource);
        }

        public (RestResponse Response, T? Bibles) GetAudioBibles<T>()
        {
            return Get<T>(AudioBiblesResource);
        }

        public (RestResponse Response, T? Bibles) GetAudioBible<T>(string id)
        {
            return Get<T>(string.Format(SingleAudioBiblesResource, id));
        }
    }
}
