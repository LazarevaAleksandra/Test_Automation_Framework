using Epam_TestAutomation_Core.Enum;
using Epam_TestAutomation_Utilities.Utils;
using NUnit.Framework;

namespace Epam_TestAutomation_Core.Helper
{
    public static partial class TestSettings
    {
        public static TestContext TestContext { get; set; }

        public static BrowserType Browser => EnumUtils.ParseEnum<BrowserType>(TestContext.Parameters.Get("Browser").ToString());

        public static string ScreenShotPath => TestContext.Parameters.Get("ScreenShotPath").ToString();

        public static string LogsPath => Path.Combine(TestContext.TestDirectory, @TestContext.Parameters.Get("LogsPath").ToString());

        public static TimeSpan WebDriverTimeOut => TimeSpan.FromSeconds(int.Parse(TestContext.Parameters.Get("WebDriverTimeOut").ToString()));

        public static string DefaultTimeOut => TestContext.Parameters.Get("WaitElementTimeOut").ToString();

        public static string ApplicationUrl => TestContext.Parameters.Get("ApplicationUrl").ToString();

<<<<<<< HEAD
        public static string InsightsUrl => TestContext.Parameters.Get("InsightsUrl").ToString();

=======


        public static string InsightsUrl => TestContext.Parameters.Get("InsightsUrl").ToString();


>>>>>>> 41582f18b222d0d2b82c1829b4a15c80a064761c
        public static string JoinOurTeamUrl => TestContext.Parameters.Get("JoinOurTeamUrl").ToString();
    }
}
