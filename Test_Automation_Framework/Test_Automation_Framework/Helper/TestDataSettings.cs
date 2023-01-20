using Epam_TestAutomation_TestData.JoinOurTeamInfo;
using Epam_TestAutomation_Utilities.Json;

namespace Epam_TestAutomation_Core.Helper
{
    public class TestDataSettings
    {
        public static List<Professions> ProfessionsNames => JsonParser.DeserializeJsonToObject<List<Professions>>(PathProfessions);

        public static List<Locations> LocationsNames => JsonParser.DeserializeJsonToObject<List<Locations>>(PathLocations);

        public static List<Skills> SkillsNames => JsonParser.DeserializeJsonToObject<List<Skills>>(PathSkills);

        public static List<JoinOurTeamFilters> FiltersNames => JsonParser.DeserializeJsonToObject<List<JoinOurTeamFilters>>(PathFilters);

        public static List<ErrorMessage> ErrorMessages => JsonParser.DeserializeJsonToObject<List<ErrorMessage>>(PathErrorMessages);

        public const string PathProfessions = @"C:\Users\Sasha\Test_Automation_Framework\Test_Automation_Framework\Epam_TestAutomation_TestData\JoinOurTeamInfo\Professions.json";

        public const string PathLocations = @"C:\Users\Sasha\Test_Automation_Framework\Test_Automation_Framework\Epam_TestAutomation_TestData\JoinOurTeamInfo\Locations.json";

        public const string PathSkills = @"C:\Users\Sasha\Test_Automation_Framework\Test_Automation_Framework\Epam_TestAutomation_TestData\JoinOurTeamInfo\Skills.json";

        public const string PathFilters = @"C:\Users\Sasha\Test_Automation_Framework\Test_Automation_Framework\Epam_TestAutomation_TestData\JoinOurTeamInfo\JoinOurTeam.json";

        public const string PathErrorMessages = @"C:\Users\Sasha\Test_Automation_Framework\Test_Automation_Framework\Epam_TestAutomation_TestData\JoinOurTeamInfo\ErrorMessage.json";
    }
}
