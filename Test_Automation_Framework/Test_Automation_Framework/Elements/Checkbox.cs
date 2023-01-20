using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_TestAutomation_Core.Elements
{
    public class Checkbox : BaseElement
    {
        public Checkbox(By locator) : base(locator)
        {
        }

        public Checkbox(IWebElement element) : base(element)
        {
        }
    }
}
