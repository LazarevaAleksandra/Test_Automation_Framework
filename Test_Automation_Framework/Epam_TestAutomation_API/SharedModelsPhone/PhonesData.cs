using Newtonsoft.Json;

namespace Epam_TestAutomation_API.SharedModelsPhone
{
    public class PhonesData
    {
        [JsonProperty("CPU model")]
        public string CPUModel { get; set; }
        [JsonProperty("Hard disk size")]
        public string HardDiskSize { get; set; }
        [JsonProperty("Strap Colour")]
        public string StrapColour { get; set; }
        [JsonProperty("Case Size")]
        public string CaseSize { get; set; }
        [JsonProperty("Screen_size")]
        public double ScreenSize { get; set; }
        [JsonProperty("capacity GB")]
        public int CapacityGb { get; set; }
        public string capacity { get; set; }
        public string color { get; set; }
        public double price { get; set; }
        public int year { get; set; }
        public string Description { get; set; }
        public string generation { get; set; }
    }
}
