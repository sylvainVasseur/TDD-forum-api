using Microsoft.AspNetCore.Mvc;

namespace forum_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TopicController : ControllerBase
    {
        private forum_api db;

        public TopicController(forum_api injectedContext)
        {
            db = injectedContext;
        }


    }
}