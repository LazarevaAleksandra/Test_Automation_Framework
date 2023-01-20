using Epam_TestAutomation_BusinessLogic.PageObjects.Pages;
using Epam_TestAutomation_Core.Browser;
using Epam_TestAutomation_Core.Helper;
using Epam_TestAutomation_TestData.JoinOurTeamInfo;
using NUnit.Framework;

namespace Epam_TestAutomation_Tests
{
    [TestFixture]
    public class DDT_1_EpamSiteNavigateTests : BaseTest
    {
        private JoinOurTeamPages _joinOurTeamPages;
        private SearchResultPages _searchResultPages;

        private static List<Professions> GetProfessionsNames() => TestDataSettings.ProfessionsNames;
        private static List<Locations> GetLocationsNames() => TestDataSettings.LocationsNames;
        private static List<Skills> GetSkillsNames() => TestDataSettings.SkillsNames;
        private static List<JoinOurTeamFilters> GetFiltersNames() => TestDataSettings.FiltersNames;
        private static List<ErrorMessage> ErrorMessagesNames() => TestDataSettings.ErrorMessages;


        [SetUp]
        public void SetUp()
        {
            _joinOurTeamPages = new JoinOurTeamPages();
            _searchResultPages = new SearchResultPages();
        }

        [Test]
        [TestCaseSource(nameof(GetProfessionsNames))]
        public void CheckKeywordInProfessionResultTest(Professions keyword)
        {         
            _joinOurTeamPages.JoinOurTeamPagesIsOpened().GetProfessionKeyword(keyword.ProfessionKeyword);
            var result = _searchResultPages.GetResultsKeyword(keyword.ProfessionKeyword);

            Assert.That(result, Is.True, "This profession was not found!");
        }

        [Test]
        [TestCaseSource(nameof(GetLocationsNames))]
        public void CheckKeywordInLocationResultTest(Locations keyword)
        {
            _joinOurTeamPages.JoinOurTeamPagesIsOpened().GetLocationKeyword(keyword.LocationKeyword);
            var result = _searchResultPages.GetResultsKeyword(keyword.LocationKeyword);

            Assert.That(result, Is.True, "This location was not found!");
        }

        [Test]
        [TestCaseSource(nameof(GetSkillsNames))]
        public void CheckKeywordInSkillResultTest(Skills keyword)
        {
            _joinOurTeamPages.JoinOurTeamPagesIsOpened().GetSkillKeyword(keyword.SkillKeyword);
            var result = _searchResultPages.GetResultsKeyword(keyword.SkillKeyword);

            Assert.That(result, Is.True, "This skill was not found!");
        }

        [Test]
        [TestCaseSource(nameof(GetFiltersNames))]
        public void CheckFiltersResultTest(JoinOurTeamFilters filter)
        {
            _joinOurTeamPages.JoinOurTeamPagesIsOpened().GetSearchFilters(filter.Profession, filter.Location, filter.Skill);
            var resultProfession = _searchResultPages.GetResultsKeyword(filter.Profession);
            var resultLocation = _searchResultPages.GetResultsKeyword(filter.Location);
            var resultSkill = _searchResultPages.GetResultsKeyword(filter.Skill);

            Assert.That(resultProfession, Is.True, "This profession was not found!");
            Assert.That(resultLocation, Is.True, "This location was not found!");
            Assert.That(resultSkill, Is.True, "This skill was not found!");
        }

        [Test]
        [TestCaseSource(nameof(ErrorMessagesNames))]
        public void CheckErrorMessageResultTest(ErrorMessage error)
        {
            var resultErrorMessage = _joinOurTeamPages.JoinOurTeamPagesIsOpened().GetErrorMessage(error.ProfessionName, error.LocationName); 
            _searchResultPages.ErrorMessageDisplayed();
            var expResultErrorMessage = "Sorry, your search returned no results. Please try another combination.";
            var actResultErrorMessage = _searchResultPages.ActualErrorMessage();

            Assert.Multiple(() =>
            {
                Assert.That(resultErrorMessage, Is.True, "System error!");
                Assert.That(expResultErrorMessage.Equals(actResultErrorMessage), "Incorrect error entry!");
            });
        }
    }
}
