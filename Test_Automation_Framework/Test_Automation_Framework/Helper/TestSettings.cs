using System.Configuration;

namespace Epam_TestAutomation_Core.Helper
{
    public static partial class TestSettings
    {
        public static string ApplicationUrl = GetConfigurationValue("ApplicationUrl");

        public static string LogsPath = Path.Combine(Directory.GetCurrentDirectory(), GetConfigurationValue("LogsPath"));

        public static string TestResourcesFolder => Path.Combine(Directory.GetCurrentDirectory(), GetConfigurationValue("TestResourcesFolder"));

        private static string GetConfigurationValue(string parameter) => ConfigurationManager.AppSettings.Get(parameter);
    }
}
