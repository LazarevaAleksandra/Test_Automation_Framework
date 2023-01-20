using Newtonsoft.Json;

namespace Epam_TestAutomation_TestData.JoinOurTeamInfo
{
    public class JoinOurTeamFilters
    {
        [JsonProperty("profession")] public string? Profession;
        [JsonProperty("location")] public string? Location;
        [JsonProperty("skill")] public string? Skill;
    }
}
