using Epam_TestAutomation_BusinessLogic.PageObjects.Pages;
using Epam_TestAutomation_Core.Browser;
using Epam_TestAutomation_Core.Utils;
using NUnit.Framework;

namespace Epam_TestAutomation_Tests
{
    [TestFixture]
    public class Basic2_EpamSiteNavigateTests : BaseTest
    {
        private MainPage _mainPage;
        private SearchResultPages _searchResultPages;

        [SetUp]
        public void SetUp()
        {
            _mainPage = new MainPage();
            _searchResultPages = new SearchResultPages();
        }

        [Test]
        public void CheckTheListOfCountriesInTheCareerButtonTest()
        {
            var countries = new List<string>() { "AMERICAS", "EMEA", "APAC" };
           
            _mainPage.CareerButton.Click();
            var careerElements = _mainPage.CareerElementsList.GetElements().Select(item => item.GetAttribute("innerText"));

            Assert.That(careerElements.Count(), Is.EqualTo(3), "Invalid number of countries!");
            Assert.That(careerElements, Is.EqualTo(countries), "Incorrect country name!");
        }

        [Test]
        public void CheckForAWordInTheSearchBoxTest()
        {
            var linkAutomation = "https://www.epam.com/search?q=Automation";

            _mainPage.SearchButton.Click();
            _mainPage.FormSearch.SendKeys("Automation");
            _mainPage.HeaderSearchButton.Click();
            var articles = _searchResultPages.Articles.GetElements().Take(5).Select(item => item.Text);

            Assert.That(BrowserFactory.Browser.GetUrl, Is.EqualTo(linkAutomation), "Incorrect url is present!");
            Assert.That(articles, Is.All.Contain("Automation").IgnoreCase, "This word is not in the article!");
        }

        [Test]
        public void CheckIfTheTitleMatchesTheFirstArticleTest()
        {
            var linkBusinessAnalysis = "https://www.epam.com/search?q=Business+Analysis";

            _mainPage.SearchButton.Click();
            _mainPage.FormSearch.SendKeys("Business Analysis");
            _mainPage.HeaderSearchButton.Click();

            Assert.That(BrowserFactory.Browser.GetUrl, Is.EqualTo(linkBusinessAnalysis), "Incorrect url is present!");

            var title = _searchResultPages.Title.GetAttribute("innerText");
            var titleOfTheFirstArticle = _searchResultPages.Title;
            _mainPage.OneTrustAcceptButton.Click();
            titleOfTheFirstArticle.Click();
            var titleBusinessAnalysis = _mainPage.TitleBusinessAnalysis.GetAttribute("innerText");

            Assert.That(titleBusinessAnalysis, Is.EqualTo(title), "Incorrect title is present!");
        }
    }
}
