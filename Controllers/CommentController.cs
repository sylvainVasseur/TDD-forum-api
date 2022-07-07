using Microsoft.AspNetCore.Mvc;

namespace forum_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentController : ControllerBase
    {
        private forum_api db;

        public CommentController(forum_api injectedContext)
        {
            db = injectedContext;
        }


    }
}
