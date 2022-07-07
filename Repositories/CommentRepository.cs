using forum_api.DataAccess.DataObjects;

namespace forum_api.Repositories
{
    public class CommentRepository
    {
        private forumdbContext _context;

        public CommentRepository(forumdbContext context)
        {
            _context = context;
        }
        //public virtual Comment FindAll()
        //{

        //}

        //Find By ID topic
        public Comment FindById(int id)
        {
            var comment = _context.Comments.SingleOrDefault(c => c.IdComment == id);
            if (comment == null)
            {
                throw new Exception($"Aucun topic avec l'id {id}, n'a été trouvé.");
            }
            else
                return comment;
        }

        public void DeleteById(int id)
        {
            var comment = _context.Comments.SingleOrDefault(c => c.IdComment == id);
            if (comment == null)
            {
                throw new Exception($"Aucun topic avec l'id {id}, n'a été trouvé.");
            }
            else
            {
                _context.Comments.Remove(comment);
                _context.SaveChanges();
            }
        }
        public void UpdateComment(int id, Comment comment)
        {
            _context.Comments.Update(comment);
            _context.SaveChanges();
        }

        public void Create(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }
    }
}
