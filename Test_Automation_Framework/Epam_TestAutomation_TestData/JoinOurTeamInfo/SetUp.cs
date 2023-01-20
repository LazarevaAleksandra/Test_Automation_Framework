using Newtonsoft.Json;

namespace Epam_TestAutomation_TestData.JoinOurTeamInfo
{
    public class SetUp
    {
        [JsonProperty("applicationUrl")] public string? ApplicationUrl { get; set; }

        [JsonProperty("jobListingUrl")] public string? JoinOurTeamUrl { get; set; }

        [JsonProperty("screenshotPath")] public string? ScreenShotPath { get; set; }

        [JsonProperty("logsPath")] public string? LogsPath { get; set; }

        [JsonProperty("webDriverTimeOut")] public int WebDriverTimeOut { get; set; }
    }
}
