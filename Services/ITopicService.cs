using forum_api.DataAccess.DataObjects;

namespace forum_api.Services
{
    public interface ITopicService
    {
        Topic FindById(int id);
        IEnumerable<Topic> FindAllTopics();
        void DeleteById(int id);
        void UpdateTopic(Topic topic);
        void CreateTopic(Topic topic);
    }
}
