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

        public virtual Topic FindById(int id)
        {
            var topic = _context.Topics.SingleOrDefault(c => c.Idtopic == id);
            if (topic == null)
            {
                throw new Exception($"Aucun topic avec l'id {id}, n'a été trouvé.");
            }
            else
            {
                return topic;
            }
        }

        public void DeleteById(int id)
        {
            var topic = _context.Topics.SingleOrDefault(c => c.Idtopic == id);
            if (topic == null)
            {
                throw new Exception($"Aucun topic avec l'id {id}, n'a été trouvé.");
            }
            else
            {
                
                _context.Topics.Remove(topic);
            }

        }
        public void UpdateTopic(Topic topic)
        {
            _context.Topics.Update(topic);
            _context.SaveChanges();
        }

        public void Create(Topic topic)
        {
            _context.Topics.Add(topic);
            _context.SaveChanges();
        }
    }
}
