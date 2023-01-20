using Newtonsoft.Json;

namespace Epam_TestAutomation_TestData.JoinOurTeamInfo
{
    public class ErrorMessage
    {
        [JsonProperty("keywordProfessions")] 
        public string? ProfessionName;

        [JsonProperty("keywordLocation")]
        public string? LocationName;
    }
}
