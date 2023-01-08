using OpenQA.Selenium;

namespace Epam_TestAutomation_Core.Elements
{
    public class Label : BaseElement
    {
        public Label(By locator) : base(locator)
        {
        }

        public Label(IWebElement element) : base(element)
        {
        }
    }
}
