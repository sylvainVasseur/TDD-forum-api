using forum_api.DataAccess.DataObjects;
using forum_api.Repositories;

namespace forum_api.Services
{
    public class CommentService : ICommentService
    {
        private ICommentRepository _repository;
        public CommentService(ICommentRepository repository)
        {
            _repository = repository;
        }

        public void CreateComment(Comment comment)
        {
            comment.CreationDate = DateTime.Now;
            _repository.CreateComment(comment);
        }

        public void DeleteComment(int id)
        {
            _repository.DeleteById(id);
        }

        public Comment FindById(int id)
        {
            var comment = _repository.FindById(id);
            if (comment == null)
            {
                throw new Exception($"Aucun comment avec l'id {id}, n'a été trouvé.");
            }
            return comment;
        }

        public List<Comment> FindByTopicId(int TpId)
        {
            var comment = _repository.FindByTopicId(TpId);
            if (comment == null)
            {
                throw new Exception($"Aucun topic avec l'id {TpId}, n'a été trouvé.");
            }
            return comment;
        }

        public void UpdateComment(Comment comment)
        {
            comment.ModificationDate = DateTime.Now;
            _repository.UpdateComment(comment);
        }
    }
}
