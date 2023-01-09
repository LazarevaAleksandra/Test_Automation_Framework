using Epam_TestAutomation_Core.Browser;
using Epam_TestAutomation_Core.Helper;
using Epam_TestAutomation_Core.Utils;
using Epam_TestAutomation_Utilities.Logger;
using NUnit.Framework;

namespace Epam_TestAutomation_Tests
{
    public abstract class BaseTest
    {
        public TestContext TestContext { get; set; }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Logger.InitLogger(TestSettings.LogsPath);
        }

        [SetUp]
        public virtual void BeforeTest()
        {
            Logger.Info("Test begin");
            BrowserFactory.Browser.GoToUrl(TestSettings.ApplicationUrl);
            Waiters.WaitForPageLoad();
        }

        [TearDown]
        public virtual void CleanTest()
        {
            Logger.Info("Test finish");
            BrowserFactory.Browser.Quit();
        }
    }
}