using System;

namespace Epam_TestAutomation_Core.Utils
{
    public static class Utils
    {
        public static T ParseEnum<T>(string value) where T : IComparable, IFormattable, IConvertible
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}
