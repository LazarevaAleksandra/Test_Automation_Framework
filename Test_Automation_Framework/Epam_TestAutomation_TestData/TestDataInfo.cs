using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Epam_TestAutomation_TestData
{
    public class TestDataInfo
    {
        [JsonPropertyName("applicationUrl")] public string ApplicationUrl { get; set; }

        [JsonPropertyName("screenshotPath")] public string ScreenshotPath { get; set; }

        [JsonPropertyName("logsPath")] public string LogsPath { get; set; }

        [JsonPropertyName("webDriverTimeOut")] public int WebDriverTimeOut { get; set; }
    }
}
