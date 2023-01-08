using OpenQA.Selenium;

namespace Epam_TestAutomation_Core.Elements
{
    public class Dropdown : BaseElement
    {
        public Dropdown(By locator) : base(locator)
        {
        }

        public Dropdown(IWebElement element) : base(element)
        {
        }
    }
}
