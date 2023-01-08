using Epam_TestAutomation_Core.BasePage;
using OpenQA.Selenium;
using Epam_TestAutomation_Core.Elements;
using Epam_TestAutomation_Core.Browser;
using Epam_TestAutomation_Core.Helper;

namespace Epam_TestAutomation_BusinessLogic.PageObjects
{
    internal class PageObjects : BasePage
    {
        public Label Title => new Label(By.TagName("h1"));

        public override bool IsOpened() => BrowserFactory.Browser.GetUrl().Equals(TestSettings.ApplicationUrl);
        
    }
}

