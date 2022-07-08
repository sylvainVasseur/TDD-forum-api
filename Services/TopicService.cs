using forum_api.DataAccess.DataObjects;
using forum_api.Repositories;

namespace forum_api.Services
{
    public class TopicService : ITopicService
    {
        private ITopicRepository _repository;

        public TopicService(ITopicRepository repository)
        {
            _repository = repository;
        }

        public Topic CreateTopic(Topic topic)
        {
            if (topic == null)
            {
                throw new Exception($"Le topic est null.");
            }
            else
            {
                topic.CreationDate = DateTime.Now;
                return _repository.CreateTopic(topic);
            }
        }

        public Topic DeleteById(int id)
        {
            if (id == null)
            {
                throw new Exception($"Aucun topic avec l'id {id}, n'a été trouvé.");
            }
            else
            {
                _ = this.FindById(id);
                return _repository.DeleteById(id);
            }
            
        }

        public IEnumerable<Topic> FindAllTopics()
        {
            return _repository.FindAllTopics();
        }

        public Topic FindById(int id)
        {
            var topic = _repository.FindById(id);
            if (topic == null)
            {
                throw new Exception($"Aucun topic avec l'id {id}, n'a été trouvé.");
            }
            return topic;
        }

        public Topic UpdateTopic(Topic topic)
        {
            if (topic == null)
            {
                throw new Exception($"Mauvais topic, null.");
            }
            topic.ModificationDate = DateTime.Now;
            return _repository.UpdateTopic(topic);
        }

    }
}
