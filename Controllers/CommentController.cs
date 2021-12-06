using Microsoft.AspNetCore.Mvc;
using refueling.Domain;
using refueling.Repository;

namespace refueling.Controllers
{
    [ApiController]
    [Route("/comment")]
    public class CommentController : ControllerBase
    {
        [HttpPut]
        public Comment Create(Comment comment)
        {
            Storage.CommentStorage.Create(comment);
            return comment;
        }

        [HttpGet]
        public Comment Read(int commentId)
        {
            return Storage.CommentStorage.Read(commentId);;
        }

        [HttpPatch]
        public Comment Update(int commentId, Comment newComment)
        {
            return Storage.CommentStorage.Update(commentId, newComment);
        }

        [HttpDelete]
        public bool Delete(int commentId)
        {
            return Storage.CommentStorage.Delete(commentId);
        }
    }
}