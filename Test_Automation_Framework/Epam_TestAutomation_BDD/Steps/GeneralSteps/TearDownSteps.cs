using Epam_TestAutomation_Core.Browser;
using Epam_TestAutomation_Core.Helper;
using Epam_TestAutomation_Utilities.Logger;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Epam_TestAutomation_BDD.Steps.GeneralSteps
{
    [Binding]
    public class TearDownSteps
    {
        [AfterScenario()]
        public static void CleanTest()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                Logger.Info("Test is failed");
                BrowserFactory.Browser.SaveScreenshoot(TestContext.CurrentContext.Test.MethodName, Path.Combine(TestContext.CurrentContext.TestDirectory, TestSettings.ScreenShotPath));
            }
            Logger.Info("Test finish");
            BrowserFactory.Browser.Quit();
        }
    }
}
