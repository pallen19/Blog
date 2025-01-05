namespace Blog.Models.Models.Request
{
    public class UserRequestModel
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public List<BlogRequest> SubscribedPosts {get;set;} = [];
    }
}
