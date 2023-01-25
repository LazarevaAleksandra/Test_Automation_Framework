using Epam_TestAutomation_BusinessLogic.PageObjects.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Epam_TestAutomation_BDD.Steps
{
    [Binding]
    public class JobSearchSteps 
    {
        private JoinOurTeamPages _joinOurTeamPages;
        private SearchResultPages _searchResultPages;

        public JobSearchSteps()
        {
            _joinOurTeamPages= new JoinOurTeamPages();
            _searchResultPages = new SearchResultPages();
        }
        [Given(@"The join our team page is opened from the main page")]
        public void GivenTheJoinOurTeamPageIsOpenedFromTheMainPage()
        {
            _joinOurTeamPages.JoinOurTeamPagesIsOpened();
        }

        [When(@"Enter profession (.*)")]
        public void WhenEnterProfession(string profession)
        {
            _joinOurTeamPages.GetProfessionKeyword(profession);
        }

        [When(@"Enter location (.*)")]
        public void WhenEnterLocation(string location)
        {
            _joinOurTeamPages.GetLocationKeyword(location);
        }

        [When(@"Enter skill (.*)")]
        public void WhenEnterSkillBusinessAndDataAnalysis(string skill)
        {
            _joinOurTeamPages.GetSkillKeyword(skill);
        }

        [Then(@"The result that contains the (.*) is displayed on the page")]
        public void ThenTheResultThatContainsTheManagerIsDisplayedOnThePage(string profession)
        {
            var result = _searchResultPages.GetResultsKeyword(profession);
            Assert.That(result, Is.True, "This profession was not found!");
        }
    }   
}
