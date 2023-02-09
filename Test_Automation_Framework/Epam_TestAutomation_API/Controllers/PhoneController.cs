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
        private const string SinglePhoneResource = "/objects/{0}";


        /// <summary>
        /// Request that receive all list of phones
        /// </summary>
        /// <typeparam name="T"><see cref="AllPhonesModels"/></typeparam>
        /// <returns>response typeof <see cref="RestResponse"/> and <see cref="AllPhonesModels"/></returns>
        public (RestResponse Response, T? Phone) GetPhones<T>()
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

        #region API_3

        /// <summary>
        /// Request that add phone
        /// </summary>
        /// <typeparam name="T"><see cref="AllPhonesModels"/></typeparam>
        /// <returns>response typeof <see cref="RestResponse"/> and <see cref="AllPhonesModels"/></returns>
        public (RestResponse Response, T Phone) AddPhone<T>(PhonesModels model)
        {
            return Post<T, PhonesModels>(PhonesResource, model);
        }

        /// <summary>
        /// Request that delete phone by ID
        /// </summary>
        /// <typeparam name="T"><see cref="AllPhonesModels"/></typeparam>
        /// <returns>response typeof <see cref="RestResponse"/> and <see cref="AllPhonesModels"/></returns>
        public (RestResponse Response, T Phone) DeletePhone<T>(string id)
        {
            return Delete<T>(string.Format(SinglePhoneResource, id));
        }

        /// <summary>
        /// Request that update phone by ID
        /// </summary>
        /// <typeparam name="T"><see cref="AllPhonesModels"/></typeparam>
        /// <returns>response typeof <see cref="RestResponse"/> and <see cref="AllPhonesModels"/></returns>
        public (RestResponse Response, T Phone) UpdatePhone<T>(string id, PhonesModels model)
        {
            return Update<T, PhonesModels>(string.Format(SinglePhoneResource, id), model);
        }

        #endregion
    }
}