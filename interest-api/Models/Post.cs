namespace interest_api.Models
{
    public class Post
    {
        public int id { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public string author { get; set; }
        public int rating { get; set; }
    }
}