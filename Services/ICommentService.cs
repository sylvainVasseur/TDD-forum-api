using forum_api.DataAccess.DataObjects;

namespace forum_api.Services
{
    public interface ICommentService
    {
        Comment FindById(int id);
        List<Comment> FindByTopicId(int TpId);
        void CreateComment(Comment comment);
        void UpdateComment(Comment comment);
        void DeleteComment(int id);
    }
}
