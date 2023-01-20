using Epam_TestAutomation_Core.BasePage;
using Epam_TestAutomation_Core.Browser;
using Epam_TestAutomation_Core.Elements;
using Epam_TestAutomation_Core.Helper;
using Epam_TestAutomation_TestData.JoinOurTeamInfo;
using OpenQA.Selenium;

namespace Epam_TestAutomation_BusinessLogic.PageObjects.Pages
{
    public class SearchResultPages : BasePage
    {
        public override bool IsOpened() => BrowserFactory.Browser.GetUrl().Equals(TestSettings.ApplicationUrl);

        public ElementList ResultsList => new ElementList(By.XPath("//*[@class='search-result__item-name']"));

        public Label ErrorMessage => new Label(By.XPath("//*[@class='search-result__error-message']"));

        public bool GetResultsKeyword(string keyword)
        {
            var result = ResultsList.GetElements().Select(item => item.GetAttribute("innerText").Contains(keyword));

            return result.Any();
        }

        public bool ErrorMessageDisplayed() => ErrorMessage.IsDisplayed();

        public string ActualErrorMessage() => ErrorMessage.GetAttribute("innerText");
    }
}
