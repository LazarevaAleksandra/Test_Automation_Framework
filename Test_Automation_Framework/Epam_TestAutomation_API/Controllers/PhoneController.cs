using Epam_TestAutomation_API.RequesModelsPhone;
using RestSharp;

namespace Epam_TestAutomation_API.Controllers
{
    public class PhoneController : BaseController
    {
        public PhoneController(CustomRestClient client) : base(client, Service.Phones) {}
        
        private const string PhonesResource = "/objects";
        private const string SinglePhonesResourceID = "/objects?id={0}";

        public (RestResponse Response, T? Phones) GetPhones<T>()
        {
            return Get<T>(PhonesResource);
        }

        public (RestResponse Response, T? Phone) GetPhonesID<T>(string id)
        {
            return Get<T>(string.Format(SinglePhonesResourceID, id));
        }
    }
}