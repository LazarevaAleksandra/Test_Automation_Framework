using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_TestAutomation_Utilities.Json
{
    public static class JsonParser
    {
        public static T DeserializeJsonToObject<T>(string json) where T : class => JsonConvert.DeserializeObject<T>(json);

        public static string SerializeJson(object content) => JsonConvert.SerializeObject(content);
    }
}
