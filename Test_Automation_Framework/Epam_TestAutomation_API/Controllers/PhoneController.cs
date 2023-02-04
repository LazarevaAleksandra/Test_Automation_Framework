using Epam_TestAutomation_API.RequesModelsPhone;
using RestSharp;

namespace Epam_TestAutomation_API.Controllers
{
    /// <summary>
    /// Class that contains methods and resources for /objects micro service
    /// </summary>
    public class PhoneController : BaseController
    {
        public PhoneController(CustomRestClient client) : base(client, Service.Phones) {}
        
        private const string PhonesResource = "/objects";
        private const string SinglePhonesResourceID = "/objects?id={0}";


        /// <summary>
        /// Request that receive all list of phones
        /// </summary>
        /// <typeparam name="T"><see cref="AllPhonesModels"/></typeparam>
        /// <returns>response typeof <see cref="RestResponse"/> and <see cref="AllPhonesModels"/></returns>
        public (RestResponse Response, T? Phones) GetPhones<T>()
        {
            return Get<T>(PhonesResource);
        }


        /// <summary>
        /// Request that receive phone by id
        /// </summary>
        /// <typeparam name="T"><see cref="AllPhonesModels"/></typeparam>
        /// <returns>response typeof <see cref="RestResponse"/> and <see cref="AllPhonesModels"/></returns>
        public (RestResponse Response, T? Phone) GetPhonesID<T>(string id)
        {
            return Get<T>(string.Format(SinglePhonesResourceID, id));
        }
    }
}