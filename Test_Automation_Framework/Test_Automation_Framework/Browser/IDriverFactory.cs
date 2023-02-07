using OpenQA.Selenium;

namespace Epam_TestAutomation_Core.Browser
{
    public interface IDriverFactory
    {
        public IWebDriver GetDriver();
    }
}
