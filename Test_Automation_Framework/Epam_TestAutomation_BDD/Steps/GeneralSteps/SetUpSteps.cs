using Epam_TestAutomation_Core.Browser;
using Epam_TestAutomation_Core.Helper;
using Epam_TestAutomation_Core.Utils;
using Epam_TestAutomation_Utilities.Logger;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Epam_TestAutomation_BDD.Steps.GeneralSteps
{
    [Binding]
    public class SetUpSteps
    {
        [BeforeFeature(Order = 1)]
        public static void OneTimeSetUp()
        {
            Logger.InitLogger(TestContext.CurrentContext.Test.Name, TestContext.CurrentContext.TestDirectory);

        }

        [BeforeScenario()]
        public static void BeforeTest()
        {
            Logger.Info("Test begin");
            BrowserFactory.Browser.GoToUrl(TestSettings.ApplicationUrl);
            BrowserFactory.Browser.Maximize();
            Waiters.WaitForPageLoad();
        }
    }
}
