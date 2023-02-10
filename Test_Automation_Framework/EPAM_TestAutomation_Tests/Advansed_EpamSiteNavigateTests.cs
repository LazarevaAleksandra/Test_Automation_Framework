using Epam_TestAutomation_BusinessLogic.PageObjects.Pages;
using Epam_TestAutomation_Core.Browser;
using NUnit.Framework;

namespace Epam_TestAutomation_Tests
{
    [TestFixture]
    public class Advansed_EpamSiteNavigateTests : BaseTest
    {
        private MainPage _mainPage;
        private SearchResultPages _searchResultPages;

        private SearchResultPages _searchResultPages;

        [SetUp]
        public void SetUp()
        {
            _mainPage = new MainPage();
            _searchResultPages = new SearchResultPages();
        }

        [Test]
        public void CheckTheOpeningOfTheLinkInTheCareerTabTest()
        {
            var linkJob = "https://www.epam.com/careers/job-listings";
            var career = _mainPage.CareerButton;
            BrowserFactory.Browser.Action.MoveToElement(career.OriginalWebElement);
            BrowserFactory.Browser.Action.Perform();
            _mainPage.JobListingsButton.Click();

            Assert.That(BrowserFactory.Browser.GetUrl, Is.EqualTo(linkJob), "Incorrect url is present!");
        }

        [Test]
        public void CheckListOfLanguagesTest()
        {
            var expectedlistOfLanguages = new List<string> {
                "Global (English)", 
                "Hungary (English)",
                "СНГ (Русский)", 
                "Česká Republika (Čeština)", 
                "India (English)", 
                "Україна (Українська)",
                "Czech Republic (English)", 
                "日本 (日本語)", 
                "中国 (中文)", 
                "DACH (Deutsch)", 
                "Polska (Polski)"};
            _mainPage.LanguagesButton.Click();
            var actualListOfLanguages = _mainPage.ListOfLanguages.GetElements().Select(language => language.GetAttribute("innerText"));

            Assert.That(actualListOfLanguages, Is.EqualTo(expectedlistOfLanguages), "Incorrect list of languages is present!");
        }

        [Test]
        public void CheckSeeMoreThan20Articles()
        {
            int expectedResult = 20;

            _mainPage.SearchButton.Click();
            _mainPage.FrequentList.Click();
            _mainPage.HeaderSearchButton.Click();
            BrowserFactory.Browser.Action.ScrollToElement(_mainPage.SearchFooter.OriginalWebElement).Perform();
            var actualResult = _searchResultPages.Articles.GetElements();

            Assert.That(actualResult, Has.Count.EqualTo(expectedResult), "Incorrect number of articles on the site!");
        }
    }
}
