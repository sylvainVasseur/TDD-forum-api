﻿using forum_api.DataAccess.DataObjects;
using forum_api.Repositories;
using forum_api.Services;

namespace forum_api.Services
{
    public class CommentService : ICommentService
    {
        private ICommentRepository _repository;
        public CommentService(ICommentRepository repository, ITopicService _topicService)
        {
            _repository = repository;
        }

        public Comment CreateComment(Comment comment)
        {
            if (comment == null)
            {
                throw new Exception($"Le comment est null.");
            }
            else
            {
                comment.CreationDate = DateTime.Now;
                return _repository.CreateComment(comment);
            }
            
        }

        public Comment DeleteComment(int id)
        {
            if (id == null)
            {
                throw new Exception($"Aucun comment avec l'id {id}, n'a été trouvé.");
            }
            return _repository.DeleteById(id);
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
                throw new Exception($"Aucun comment avec l'id {TpId}, n'a été trouvé.");
            }
            return comment;
        }

        public Comment UpdateComment(Comment comment)
        {
            if (comment == null)
            {
                throw new Exception($"Mauvais Comment, null.");
            }
            comment.ModificationDate = DateTime.Now;
            return _repository.UpdateComment(comment);
        }

    }
}
