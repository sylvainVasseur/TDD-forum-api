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

        //public virtual Topic FindAll()
        //{
        //    return _context.Topics.SelectMany(t => t.Topics).ToList();
        //}

        public virtual Topic FindById(int id)
        {
            if (_context.Topics.Find(id) == null)
            {
                throw new Exception($"Aucun topic avec l'id {id}, n'a été trouvé.");
            }
            else
            {
                return _context.Topics.Find(id);
            }
        }

        public virtual Topic DeleteById(int id)
        {
            if (_context.Topics.Find(id) == null)
            {
                throw new Exception($"Aucun topic avec l'id {id}, n'a été trouvé.");
            }
            else
            {
                var topic = _context.Topics.Find(id);
                _context.Topics.Remove(_context.Topics.Find(id));

                return topic;
            }

        }
        public virtual Topic UpdateTopic(int id , Topic topic)
        {
            _context.Topics.Update(topic);
            _context.SaveChanges();
            return topic;
        }

        public virtual Topic Create(Topic topic)
        {
            _context.Topics.Add(topic);
            _context.SaveChanges();
            return topic;
        }
    }
}
