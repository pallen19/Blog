namespace Blog.Models.Models.Request
{
    public class BlogRequest
    {
        public Guid BlogId { get; set; }
        public string Title {get; set;} = string.Empty;
        public string Content {get; set;} = string.Empty;
        public byte[] MediaContent {get; set;} = [];
        public List<UserRequestModel> Subscribers { get; set; } = [];
        public DateTime CreatedOn {get; set;}
        public DateTime UpdatedOn{get; set;}
        public string UpdatedBy{get; set;} = string.Empty;
    }
}
