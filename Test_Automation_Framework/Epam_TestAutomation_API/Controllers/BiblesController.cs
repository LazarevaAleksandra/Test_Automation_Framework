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
        private const string SingleBiblesResource = "/v1/bibles/{0}";
        private const string AudioBiblesResource = "/v1/audio-bibles";
        private const string SingleAudioBiblesResource = "/v1/audio-bibles/{0}";
        private const string BooksResourse = "/v1/bibles/{0}/books";
        private const string SingleBooksResourse = "/v1/bibles/{0}/books/{1}/chapters";

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

        #region Books

        /// <summary>
        /// Request that receive book
        /// </summary>
        /// <typeparam name="T"><see cref="SingleBible"/></typeparam>
        /// <returns>response typeof <see cref="RestResponse"/> and <see cref="SingleBible"/></returns>
        public (RestResponse Response, T? Books) GetBook<T>(string id)
        {
            return Get<T>(string.Format(SingleBiblesResource, id));
        }

        /// <summary>
        /// Request that receive all list of books
        /// </summary>
        /// <typeparam name="T"><see cref="AllBooksModels"/></typeparam>
        /// <returns>response typeof <see cref="RestResponse"/> and <see cref="AllBooksModels"/></returns>
        public (RestResponse Response, T? Books) GetBooks<T>(string id)
        {
            return Get<T>(string.Format(BooksResourse, id));
        }

        /// <summary>
        /// Request that receive chapters of book
        /// </summary>
        /// <typeparam name="T"><see cref="Chapters"/></typeparam>
        /// <returns>response typeof <see cref="RestResponse"/> and <see cref="Chapters"/></returns>
        public (RestResponse Response, T? Chapters) GetChapters<T>(string biblesId, string bookId)
        {
            return Get<T>(string.Format(SingleBooksResourse, biblesId, bookId));
        }

        #endregion
    }
}
