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
            if (_context.Comments.SingleOrDefault(c => c.IdComment == id) == null)
            {
                throw new Exception($"Aucun topic avec l'id {id}, n'a été trouvé.");
            }
            else
                return _context.Comments.SingleOrDefault(c => c.IdComment == id);
        }

        public void DeleteById(int id)
        {
            if (_context.Comments.SingleOrDefault(c => c.IdComment == id) == null)
            {
                throw new Exception($"Aucun topic avec l'id {id}, n'a été trouvé.");
            }
            else
            {
                var comment = _context.Comments.SingleOrDefault(c => c.IdComment == id);
                _context.Comments.Remove(comment);
                _context.SaveChanges();
            }
        }
        public virtual Comment UpdateById(int id)
        {

        }

        public virtual Comment Create(Comment comment)
        {

        }
    }
}
