using refueling.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace refueling.Repository
{
    public class CommentStorage
    {
        private Dictionary<int, Comment> Comments { get; } = new Dictionary<int, Comment>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CommentStorage() => Connection.Open();

        public void Create(Comment comment)
        {
            Comments.Add(comment.CommentId, comment);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Comment Read(int CommentId)
        {
            return Comments[CommentId];
        }

        public Comment Update(int CommentId, Comment newComment)
        {
            Comments[CommentId] = newComment;
            return Comments[CommentId];
        }

        public bool Delete(int CommentId)
        {
            return Comments.Remove(CommentId);
        }
    }
}