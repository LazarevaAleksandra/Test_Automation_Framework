using Epam_TestAutomation_BusinessLogic.PageObjects.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_TestAutomation_Tests
{
    [TestFixture]
    public class DDT_1_EpamSiteNavigateTests
    {
        private SearchResultsPage _searchResultsPage;

        [SetUp]
        public void SetUp()
        {
            _searchResultsPage = new SearchResultsPage();
        }

        [Test]
        public void CheckKeywordInSearchResultTest()
        {

        }
    }
}
