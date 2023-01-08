using Epam_TestAutomation_Core.Browser;
using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace Epam_TestAutomation_Core.Elements
{
    public class ElementList
    {
        private readonly List<IWebElement> _elements;
        private readonly By _locator;
        private readonly IWebElement _element;

        public ElementList(By locator)
        {
            _locator = locator;
            _elements = FindElements(locator).ToList();
        }

        public List<IWebElement> GetElements()
        {
            return _elements.ToList();
        }

        public ReadOnlyCollection<IWebElement> FindElements(By locator)
        {
            if (_element != null)
            {
                return _element.FindElements(locator);
            }

            return BrowserFactory.Browser.FindElements(locator);
        }
    }
}
