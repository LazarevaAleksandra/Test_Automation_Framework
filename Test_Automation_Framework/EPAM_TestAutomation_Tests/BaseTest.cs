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
            Logger.InitLogger(TestContext.CurrentContext.Test.Name, TestContext.CurrentContext.TestDirectory);
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
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                Logger.Info("Test is failed");
                BrowserFactory.Browser.SaveScreenshoot(TestContext.CurrentContext.Test.MethodName,
                    Path.Combine(TestContext.CurrentContext.TestDirectory, TestSettings.ScreenShotPath));
            }
            Logger.Info("Test finish");
            BrowserFactory.Browser.Quit();
        }
    }
}