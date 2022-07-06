using forum_api.DataAccess.DataObjects;
using forum_api.Repositories;

namespace forum_api.Services
{
    public class TopicService
    {
        private TopicRepository repository;

        public TopicService(TopicRepository repository)
        {
            this.repository = repository;
        }
        
        public Topic FindAll()
        {
            
        }
    }
}
