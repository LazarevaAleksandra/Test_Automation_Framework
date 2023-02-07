using Newtonsoft.Json;

namespace Epam_TestAutomation_Utilities.Json
{
    public static class JsonParser
    {
        public static List<T> DeserializeJsonToObject<T>(string json) => JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(json));

        public static T DeserializeJsonToObjects<T>(string json) => JsonConvert.DeserializeObject<T>(File.ReadAllText(json));

        public static string SerializeJson(object content) => JsonConvert.SerializeObject(content);
    }
}
