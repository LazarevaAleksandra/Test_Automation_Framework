//using Epam_TestAutomation_Core.Enum;
//using Epam_TestAutomation_Utilities.Utils;

//namespace Epam_TestAutomation_Core.Helper
//{
//    public static partial class TestSettings
//    {
//        public static readonly BrowserType Browser = EnumUtils.ParseEnum<BrowserType>
//            (GetConfigurationValue("Browser") ?? "undefind");

//        public static readonly TimeSpan WebDriverTimeOut = TimeSpan.FromSeconds
//            (int.Parse(GetConfigurationValue("WebDriverTimeOut") ?? "0"));

//        public static readonly TimeSpan WaitElementTimeOut = TimeSpan.FromSeconds
//            (int.Parse(GetConfigurationValue("WaitElementTimeOut") ?? "0"));

//        public static readonly string ScreenShotPath = Path.Combine(Directory.GetCurrentDirectory(), 
//            GetConfigurationValue("ScreenShotPath") ?? string.Empty);
//    }
//}
