using OpenQA.Selenium;

namespace Epam_TestAutomation_Core.Elements
{
    public class Link : BaseElement
    {
        public Link(By locator) : base(locator)
        {
        }

        public Link(IWebElement element) : base(element)
        {
        }
    }
}
