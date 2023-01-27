using Epam_TestAutomation_Core.BasePage;
using Epam_TestAutomation_Core.Browser;
using Epam_TestAutomation_Core.Elements;
using Epam_TestAutomation_Core.Helper;
using OpenQA.Selenium;

namespace Epam_TestAutomation_BusinessLogic.PageObjects.Pages
{
    public class InsightsPage : BasePage
    {
        public Link Insights = new Link(By.XPath("//*[@href = '/insights']"));

        public override bool IsOpened() => BrowserFactory.Browser.GetUrl().Equals(TestSettings.InsightsUrl);

        public bool ManePageIsOpened() => BrowserFactory.Browser.GetUrl().Equals(TestSettings.ApplicationUrl);
    }
}
