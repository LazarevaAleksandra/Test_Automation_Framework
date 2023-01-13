﻿using Epam_TestAutomation_BusinessLogic.PageObjects.Pages;
using Epam_TestAutomation_Core.Browser;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Epam_TestAutomation_Tests
{
    public class Advansed_EpamSiteNavigateTests : BaseTest
    {
        private SearchResultsPage _searchResultsPage;

        [SetUp]
        public void SetUp()
        {
            _searchResultsPage = new SearchResultsPage();
        }

        [Test]
        public void CheckTheOpeningOfTheLinkInTheCareerTabTest()
        {
            var linkJob = "https://www.epam.com/careers/job-listings";
            var career = _searchResultsPage.CareerButton;
            BrowserFactory.Browser.Action.MoveToElement((IWebElement)career);
            BrowserFactory.Browser.Action.Perform();
            _searchResultsPage.JobListingsButton.Click();

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
            _searchResultsPage.LanguagesButton.Click();
            var actualListOfLanguages = BrowserFactory.Browser.Waiters().
                Until(driver => driver.FindElements(By.XPath("//*[@class = 'location-selector__item']")))
                .Select(language => language.GetAttribute("innerText"));

            Assert.That(actualListOfLanguages, Is.EqualTo(expectedlistOfLanguages), "Incorrect list of languages is present!");
        }

        [Test]
        public void CheckSeeMoreThan20Articles()
        {
            int expectedResult = 20;

            BrowserFactory.Browser.ExecuteScript("arguments[0].click()", _searchResultsPage.SearchButton);
            _searchResultsPage.FrequentList.Click();
            _searchResultsPage.HeaderSearchButton.Click();
            BrowserFactory.Browser.Action.ScrollToElement((IWebElement)_searchResultsPage.SearchFooter).Perform();
            var actualResult = new List<IWebElement> ((IEnumerable<IWebElement>)_searchResultsPage.Articles);

            Assert.That(actualResult, Has.Count.EqualTo(expectedResult), "Incorrect number of articles on the site");
        }
    }
}