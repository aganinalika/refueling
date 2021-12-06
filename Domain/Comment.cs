namespace refueling.Domain
{
    public class Comment
    {
        public int CommentId { get; set; }
        public object Data { get; set; }
        public Station Refueling { get; set; }
        public Error Error { get; set; }
    }
}