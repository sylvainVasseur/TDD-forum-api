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

        public void CreateTopic(Topic topic)
        {
            topic.CreationDate = DateOnly.FromDateTime(DateTime.Now);
            _repository.CreateTopic(topic);
        }

        public void DeleteById(int id)
        {
            _repository.DeleteById(id);
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

        public void UpdateTopic(Topic topic)
        {
            topic.ModificationDate = DateOnly.FromDateTime(DateTime.Now);
            _repository.UpdateTopic(topic);
        }
    }
}
