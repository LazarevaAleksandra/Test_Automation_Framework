using Epam_TestAutomation_Core.Browser;
using Epam_TestAutomation_Core.Enum;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Epam_TestAutomation_Core.Driver
{
    public static class DriverFactory
    {
        public static IWebDriver GetWebDriver(BrowserType browser)
        {
            IWebDriver webDriver;
            switch (browser)
            {
                case BrowserType.Chrome:
                    webDriver = new ChromeBrowser().GetDriver();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(browser));
            }
            return webDriver;
        }
    }
}

