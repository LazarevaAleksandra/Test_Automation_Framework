
namespace Epam_TestAutomation_API.ResponseModels
{
    public class Chapters
    {
        public List<Chapter> data { get; set; }
       
       
    }

    public class Chapter
    {
        public string id { get; set; }
        public string bibleId { get; set; }
        public string bookId { get; set; }
        public string number { get; set; }
        public string reference { get; set; }
    }
}
