using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_TestAutomation_Core.Element
{
    public interface IBaseElement
    {
        string GetText();
        string GetAttribute(string attributeName);

        void Click();
        void SendKeys(string text);
        void Clear();

        bool IsDisplayed();
        bool IsEnabled();
    }
}
