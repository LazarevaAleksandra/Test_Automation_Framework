using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using Epam_TestAutomation_Utilities.Logger;
using Epam_TestAutomation_Core.Helper;
using Epam_TestAutomation_Core.Screenshot;

namespace Epam_TestAutomation_Core.Browser
{
    public class Browser
    {
        private readonly IWebDriver _driver;

        public Browser(IWebDriver driver)
        {
            _driver = driver;
        }

        public void ScrollToElement(IWebElement element)
        {
            ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public void Back()
        {
            Logger.Info("Navigate Back");
            _driver.Navigate().Back();
        }

        public string GetUrl()
        {
            return _driver.Url;
        }

        public void Maximize()
        {
            Logger.Info("Maximize Browser");
            _driver.Manage().Window.Maximize();
        }

        public void Refresh()
        {
            Logger.Info("Refresh page");
            _driver.Navigate().Refresh();
        }

        public void GoToUrl(string url)
        {
            Logger.Info($"Open url: {url}");
            _driver.Navigate().GoToUrl(url);
        }

        public void ScrollTop()
        {
            Logger.Info("Scroll page top");
            ExecuteScript("$(window).scrollTop(0)");
        }

        public void Close()
        {
            Logger.Info("Close current page");
            _driver.Close();
        }

        public void Quit()
        {
            Logger.Info("Quit Browser");           
            _driver.Quit();
        }

        public string Url
        {
            get => _driver.Url;
            set => _driver.Url = value;
        }

        public WebDriverWait Waiters() => new WebDriverWait(_driver, TestSettings.WebDriverTimeOut);

        public void SaveScreenshoot(string screenshotName, string folderPath)
        {
            ScreenshotTaker.TakeScreenshot(_driver, screenshotName, folderPath);
        }

        public Actions Action => new Actions(_driver);

        public IWebElement FindElement(By locator)
        {
            return _driver.FindElement(locator);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return _driver.FindElements(by);
        }

        public object ExecuteScript(string script, params object[] args)
        {
            return ((IJavaScriptExecutor)_driver).ExecuteScript(script, args);
            return null;
        }
    }
}
