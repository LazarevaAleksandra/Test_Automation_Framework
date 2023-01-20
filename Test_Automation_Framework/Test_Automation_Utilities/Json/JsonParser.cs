using Newtonsoft.Json;

namespace Epam_TestAutomation_Utilities.Json
{
    public static class JsonParser
    {
        public static T DeserializeJsonToObject<T>(string path) => JsonConvert.DeserializeObject<T>(File.ReadAllText(path));

        public static string SerializeJson(object content) => JsonConvert.SerializeObject(content);
    }
}
