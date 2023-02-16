using Epam_TestAutomation_Core.BasePage;
using Epam_TestAutomation_Core.Browser;
using Epam_TestAutomation_Core.Elements;
using Epam_TestAutomation_Core.Helper;
using OpenQA.Selenium;

namespace Epam_TestAutomation_BusinessLogic.PageObjects.Pages
{
    public class SearchResultPages : BasePage
    {
        public ElementList Articles => new ElementList(By.XPath("//*[@class = 'search-results__item']"));

        public Label Title => new Label(By.XPath("//*[@class = 'search-results__title-link']"));

        public ElementList ResultsList => new ElementList(By.XPath("//*[@class='search-result__item-name']"));

        public override bool IsOpened() => BrowserFactory.Browser.GetUrl().Equals(TestSettings.JoinOurTeamUrl);

        public bool GetResultsKeyword(string keyword)
        {
            var result = ResultsList.GetElements().Select(item => item.GetAttribute("innerText").Contains(keyword));

            return result.Any();
        }       
    }
}
