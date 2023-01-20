using Epam_TestAutomation_Core.Browser;
using Epam_TestAutomation_Core.Helper;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_TestAutomation_Tests
{
    [TestFixture]
    public class Basic1_EpamSiteNavigateTests : BaseTest
    {
        [Test]
        public void CheckBrowserPageTest()
        {
            var link = TestSettings.ApplicationUrl;

            Assert.That(BrowserFactory.Browser.GetUrl, Is.EqualTo(link), "Incorrect url is present!");
        }

        [Test]
        public void CheckPageAfterReloadTest()
        {
            var linkHoWeDoIt = "https://www.epam.com/how-we-do-it";
            var linkOurWork = "https://www.epam.com/our-work";

            BrowserFactory.Browser.GoToUrl(linkHoWeDoIt);
            BrowserFactory.Browser.GoToUrl(linkOurWork);
            BrowserFactory.Browser.Refresh();
            BrowserFactory.Browser.Back();

            Assert.That(BrowserFactory.Browser.GetUrl, Is.EqualTo(linkHoWeDoIt), "Incorrect url is present!");
        }    
    }
}
