using Epam_TestAutomation_Core.Browser;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;
using System.Drawing;

namespace Epam_TestAutomation_Core.Elements
{
    public abstract class BaseElement : IBaseElement
    {
        private readonly IWebElement _element;

        protected BaseElement(By locator)
        {
            _element = BrowserFactory.Browser.FindElement(locator);
        }

        protected BaseElement(IWebElement element)
        {
            _element = element;
        }

        public IWebElement OriginalWebElement => _element;

        public string GetText() => OriginalWebElement.Text.Trim();

        public string GetAttribute(string attributeName) => OriginalWebElement.GetAttribute(attributeName);

        public virtual void Click()
        {
            OriginalWebElement.Click();
        }

        public void SendKeys(string text)
        {
            OriginalWebElement.SendKeys(text);
        }

        public void Clear()
        {
            OriginalWebElement.Clear();
        }

        public bool Exists()
        {
            return OriginalWebElement != null;
        }

        public bool IsDisplayed() => OriginalWebElement.Displayed;

        public bool IsEnabled() => OriginalWebElement.Enabled;

        public int GetWidth() => OriginalWebElement.Size.Width;

        public int GetHeight() => OriginalWebElement.Size.Height;

        public Point GetLocation() => OriginalWebElement.Location;

        public IWebElement FindElement(By by) => OriginalWebElement.FindElement(by);

        public ReadOnlyCollection<IWebElement> FindElements(By by) => OriginalWebElement.FindElements(by);

        public Actions Actions()
        {
            return BrowserFactory.Browser.Action;
        }

        public void MoveToElement()
        {
            BrowserFactory.Browser.Action.MoveToElement(OriginalWebElement).Perform();
        }

        public void ScrollToElement()
        {
            BrowserFactory.Browser.Action.ScrollToElement(OriginalWebElement).Perform();
        }
    }
}
       

