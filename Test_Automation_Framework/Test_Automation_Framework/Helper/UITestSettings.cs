using Epam_TestAutomation_Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_TestAutomation_Core.Helper
{
    public static partial class TestSettings
    {
        public static readonly BrowserType Browser = Utils.ParseEnum<BrowserType>
            (GetConfigurationValue("Browser") ?? "undefind");
    }
}
