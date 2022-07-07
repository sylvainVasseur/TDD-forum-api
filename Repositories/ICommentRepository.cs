using forum_api.DataAccess.DataObjects;

namespace forum_api.Repositories
{
    public interface ICommentRepository
    {
        Comment FindById(int id);
        List<Comment> FindByTopicId(int TpId);
        void UpdateComment(Comment comment);
        void CreateComment(Comment comment);
        void DeleteById(int id);
    }
}
