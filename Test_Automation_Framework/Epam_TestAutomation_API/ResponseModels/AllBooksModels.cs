
namespace Epam_TestAutomation_API.ResponseModels
{
    public class AllBooksModels
    {
        public Books[] data { get; set; }  
    }
    
    public class Books
    {
        public string id { get; set; }
        public string bibleId { get; set; }
        public string bookId { get; set; }
        public string name { get; set; }
        public string nameLong { get; set; }
        public string abbreviation { get; set; }
        public string number { get; set; }
        public string reference { get; set; }
    }
}
