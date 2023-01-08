using OpenQA.Selenium;

namespace Epam_TestAutomation_Core.Elements
{
    public class BasePanel : BaseElement
    {
        public BasePanel(By locator) : base(locator)
        {
        }

        public BasePanel(IWebElement element) : base(element)
        {
        }
    }
}
