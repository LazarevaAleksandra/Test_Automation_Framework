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

        [When(@"Enter the profession (.*) in the Keyword field")]
        public void WhenEnterTheProfessionManagerInTheKeywordField(string profession)
        {
            _joinOurTeamPages.FillInSearchFilter(profession);
        }

        [When(@"Enter the location (.*) in the All Locations field")]
        public void WhenEnterTheLocationYerevanInTheAllLocationsField(string location)
        {
            _joinOurTeamPages.FillInSearchFilter(location);
        }

        [When(@"Enter the skill (.*) in the All Skills field")]
        public void WhenEnterTheSkillBusinessAndDataAnalysisInTheAllSkillsField(string skill)
        {
            _joinOurTeamPages.FillInSearchFilter(skill);
        }

        [Then(@"The result that contains the (.*) is displayed on the JoinOurTeam page")]
        public void ThenTheResultThatContainsTheManagerIsDisplayedOnTheJoinOurTeamPage(string profession)
        {
            var result = _searchResultPages.GetResultsKeyword(profession);
            Assert.That(result, Is.True, "This profession was not found!");
        }
    }
}
