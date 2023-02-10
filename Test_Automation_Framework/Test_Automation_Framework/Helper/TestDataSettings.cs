using Epam_TestAutomation_TestData.JoinOurTeamInfo;
using Epam_TestAutomation_Utilities.Json;

namespace Epam_TestAutomation_Core.Helper
{
    public class TestDataSettings
    {
        public static List<Professions> ProfessionsNames => JsonParser.DeserializeJsonToObject<Professions>(PathProfessions);

        public static List<Locations> LocationsNames => JsonParser.DeserializeJsonToObject<Locations>(PathLocations);

        public static List<Skills> SkillsNames => JsonParser.DeserializeJsonToObject<Skills>(PathSkills);

        public static List<JoinOurTeamFilters> FiltersNames => JsonParser.DeserializeJsonToObject<JoinOurTeamFilters>(PathFilters);

        public static List<ErrorMessage> ErrorMessages => JsonParser.DeserializeJsonToObject<ErrorMessage>(PathErrorMessages);

        public static string PathProfessions = Path.Join(Directory.GetCurrentDirectory(), @"JoinOurTeamInfo\Professions.json");

        public static string PathLocations = Path.Join(Directory.GetCurrentDirectory(), @"JoinOurTeamInfo\Locations.json");

        public static string PathSkills = Path.Join(Directory.GetCurrentDirectory(), @"JoinOurTeamInfo\Skills.json");
         
        public static string PathFilters = Path.Join(Directory.GetCurrentDirectory(), @"JoinOurTeamInfo\JoinOurTeam.json");

        public static string PathErrorMessages = Path.Join(Directory.GetCurrentDirectory(), @"JoinOurTeamInfo\ErrorMessage.json");
    }
}
