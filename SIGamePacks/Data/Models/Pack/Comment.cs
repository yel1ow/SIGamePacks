namespace SIGamePacks.Data.Models.Pack
{
    public class Comment
    {
        public Comment(string commentText, string authorName)
        {
            CommentText = commentText;
            AuthorName = authorName;
            LikesCount = 0;
            DislikesCount = 0;
        }

        public int Id { get; set; }
        public string CommentText { get; }
        public string AuthorName { get; }
        public int LikesCount { get; }
        public int DislikesCount { get; }
    }
}