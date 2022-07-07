using forum_api.DataAccess.DataObjects;

namespace forum_api.Repositories
{
    public interface ITopicRepository
    {
        Topic FindById(int id);
        IEnumerable<Topic> FindAllTopics();
        void DeleteById(int id);
        void UpdateTopic(Topic topic);
        Topic CreateTopic(Topic topic);
    }
}
