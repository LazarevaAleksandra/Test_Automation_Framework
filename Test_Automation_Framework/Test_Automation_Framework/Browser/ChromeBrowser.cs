using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Epam_TestAutomation_Core.Browser
{
    public class ChromeBrowser : IDriverFactory
    {
        public IWebDriver GetDriver()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--start-maximized");
            var service = ChromeDriverService.CreateDefaultService();
            var chromeDriver = new ChromeDriver(service, chromeOptions, TimeSpan.FromMinutes(3));
            return chromeDriver;
        }
    }
}
