using Epam_TestAutomation_BusinessLogic.PageObjects.Pages;
using Epam_TestAutomation_Core.Browser;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Epam_TestAutomation_Tests
{
    [TestFixture]
    public class Basic2_EpamSiteNavigateTests : BaseTest
    {
        private SearchResultsPage _searchResultsPage;

        [SetUp]
        public void SetUp()
        {
            _searchResultsPage = new SearchResultsPage();
        }

        [Test]
        public void CheckTheListOfCountriesInTheCareerButtonTest()
        {
            var countries = new List<string> { "AMERICAS", "EMEA", "APAC" };

            _searchResultsPage.CareerButton.Click();      
            var careerElements = _searchResultsPage.CareerElementsList.GetElements().Select(item => item.GetAttribute("innerText"));

            Assert.That(careerElements.Count(), Is.EqualTo(3), "Invalid number of countries!");
            Assert.That(careerElements, Is.EqualTo(countries), "Incorrect country name!");
        }

        [Test]
        public void CheckForAWordInTheSearchBoxTest()
        {
            var linkAutomation = "https://www.epam.com/search?q=Automation";

            _searchResultsPage.SearchButton.Click();
            _searchResultsPage.FormSearch.SendKeys("Automation");
            _searchResultsPage.HeaderSearchButton.Click();
            var articles = _searchResultsPage.Articles.GetElements().Take(5).Select(item => item.Text);

            Assert.That(BrowserFactory.Browser.GetUrl, Is.EqualTo(linkAutomation), "Incorrect url is present!");
            Assert.That(articles, Is.All.Contain("Automation").IgnoreCase, "This word is not in the article!");
        }

        [Test]
        public void CheckIfTheTitleMatchesTheFirstArticleTest()
        {
            var linkBusinessAnalysis = "https://www.epam.com/search?q=Business+Analysis";

            _searchResultsPage.SearchButton.Click();
            _searchResultsPage.FormSearch.SendKeys("Business Analysis");
            _searchResultsPage.HeaderSearchButton.Click();

            Assert.That(BrowserFactory.Browser.GetUrl, Is.EqualTo(linkBusinessAnalysis), "Incorrect url is present!");

            var title = _searchResultsPage.Title.GetAttribute("innerText");
            var titleOfTheFirstArticle = _searchResultsPage.TitleOfTheFirstArticle;
            _searchResultsPage.OnetrustAcceptButton.Click();
            titleOfTheFirstArticle.Click();
            var titleBusinessAnalysis = _searchResultsPage.TitleBusinessAnalysis.GetAttribute("innerText");

            Assert.That(titleBusinessAnalysis, Is.EqualTo(title), "Incorrect title is present!");
        }
    }
}
