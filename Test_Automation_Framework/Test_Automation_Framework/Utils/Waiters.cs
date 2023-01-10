using Epam_TestAutomation_Core.Browser;
using OpenQA.Selenium;

namespace Epam_TestAutomation_Core.Utils
{
    public static class Waiters
    {
        public static void WaitForPageLoad() => BrowserFactory.Browser.Waiters().Until
            (condition => BrowserFactory.Browser.ExecuteScript("return document.readyState").Equals("complete"));

        public static void WaitForCondition(Func<bool> condition) => 
            BrowserFactory.Browser.Waiters().Until(x => condition.Invoke());
    }
}
