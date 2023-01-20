using Epam_TestAutomation_Core.Enum;
using Epam_TestAutomation_TestData.JoinOurTeamInfo;
using Epam_TestAutomation_Utilities.Json;
using Epam_TestAutomation_Utilities.Utils;
using NUnit.Framework;

namespace Epam_TestAutomation_Core.Helper
{
    public static partial class TestSettings
    {
        public static TestContext TestContext { get; set; }

        public static BrowserType Browser => EnumUtils.ParseEnum<BrowserType>(TestContext.Parameters.Get("Browser").ToString());

        public static string ScreenShotPath => SetUp.ScreenShotPath;

        public static string LogsPath => SetUp.LogsPath;

        public static TimeSpan WebDriverTimeOut => TimeSpan.FromSeconds(SetUp.WebDriverTimeOut);

        public static string DefaultTimeOut => TestContext.Parameters.Get("WaitElementTimeOut").ToString();

        public static string ApplicationUrl => SetUp.ApplicationUrl;

        public static string JoinOurTeamUrl => SetUp.JoinOurTeamUrl;

        public static SetUp SetUp => GetSetUp();

        public static SetUp GetSetUp() => JsonParser.DeserializeJsonToObject<SetUp>
            (@"C:\Users\Sasha\Test_Automation_Framework\Test_Automation_Framework\Epam_TestAutomation_TestData\JoinOurTeamInfo\SetUp.json");
    }
}
