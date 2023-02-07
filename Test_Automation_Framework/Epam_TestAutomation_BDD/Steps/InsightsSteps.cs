using Epam_TestAutomation_BusinessLogic.PageObjects.Pages;
using Epam_TestAutomation_Core.Utils;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Epam_TestAutomation_BDD.Steps
{
    [Binding]
    public class InsightsSteps
    {
        private InsightsPage _insightsPage;

        public InsightsSteps()
        {          
            _insightsPage = new InsightsPage();
        }

        [Given(@"I navigate to Epam site")]
        public void GivenINavigateToEpamSite()
        {
            _insightsPage.ManePageIsOpened();
            Waiters.WaitForPageLoad();
        }

        [When(@"I click '([^']*)' link on Epam site")]
        public void WhenIClickLinkOnEpamSite(string insights)
        {
            _insightsPage.Insights.Click();
        }

        [Then(@"I check that Insights page is opened")]
        public void ThenICheckThatInsightsPageIsOpened()
        {
            Waiters.WaitForPageLoad();
            Assert.That(_insightsPage.IsOpened(), Is.True, "Insights page should be opened!");
        }
    }
}
