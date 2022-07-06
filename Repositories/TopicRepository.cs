using forum_api.DataAccess.DataObjects;

namespace forum_api.Repositories
{
    public class TopicRepository
    {
        private forumdbContext _context;

        public TopicRepository(forumdbContext context)
        {
            _context = context;
        }

        public virtual Topic FindAll()
        {
            _context.Topics.
        }

        public virtual Topic FindById(int id)
        {
            _context.Topics.
        }

        public virtual Topic DeleteById(int id)
        {

        }
        public virtual Topic UpdateById(int id)
        {

        }

        public virtual Topic Create(Topic topic)
        {

        }
    }
}
