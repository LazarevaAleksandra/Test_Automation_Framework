using RestSharp;

namespace Epam_TestAutomation_API.Controllers
{
    /// <summary>
    /// Class that contains methods and resources for /v1 micro service
    /// </summary>
    public class BiblesController : BaseController
    {
        public BiblesController(CustomRestClient client, string apiKey = "") : base(client, Service.Bibles, apiKey) {}

        public BiblesController(CustomRestClient client) : base(client, Service.Bibles, client._apiConfig.ApiKey) {}

        private const string BiblesResource = "/v1/bibles";     
        private const string AudioBiblesResource = "/v1/audio-bibles";
        private const string SingleAudioBiblesResource = "/v1/audio-bibles/{0}";

        /// <summary>
        /// Request that receive all list of bibles
        /// </summary>
        /// <typeparam name="T"><see cref="AllBiblesModels"/></typeparam>
        /// <returns>response typeof <see cref="RestResponse"/> and <see cref="AllBiblesModels"/></returns>
        public (RestResponse Response, T? Bibles) GetBibles<T>()
        {
            return Get<T>(BiblesResource);
        }

        /// <summary>
        /// Request that receive all list of audio bibles
        /// </summary>
        /// <typeparam name="T"><see cref="AllBiblesModels"/></typeparam>
        /// <returns>response typeof <see cref="RestResponse"/> and <see cref="AllBiblesModels"/></returns>
        public (RestResponse Response, T? Bibles) GetAudioBibles<T>()
        {
            return Get<T>(AudioBiblesResource);
        }

        /// <summary>
        /// Request that receive audio bible
        /// </summary>
        /// <typeparam name="T"><see cref="AllBiblesModels"/></typeparam>
        /// <returns>response typeof <see cref="RestResponse"/> and <see cref="AllBiblesModels"/></returns>
        public (RestResponse Response, T? Bibles) GetAudioBible<T>(string id)
        {
            return Get<T>(string.Format(SingleAudioBiblesResource, id));
        }
    }
}
