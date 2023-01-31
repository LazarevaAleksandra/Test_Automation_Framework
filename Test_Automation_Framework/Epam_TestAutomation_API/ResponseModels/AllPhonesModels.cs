using Epam_TestAutomation_API.SharedModelsPhone;

namespace Epam_TestAutomation_API.ResponseModels
{
    public class AllPhonesModels
    {
        public string id { get; set; }
        public string name { get; set; }
        public PhonesData? data { get; set; }
        public DateTime createdAt { get; set; }
    }
}
