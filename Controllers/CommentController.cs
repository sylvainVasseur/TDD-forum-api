using Microsoft.AspNetCore.Mvc;
//using forum_api.Services;
using Microsoft.AspNetCore.Http;


namespace forum_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentController : ControllerBase
    {
        private forum_api db;

        private readonly CommentService _services;

        public CommentController(forum_api injectedContext)
        {
            db = injectedContext;
        }

        [HttpGet]
        public IActionResult FindAll()
        {
            return Ok(this._service.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult FindById(string id)
        {
            return Ok(this._service.FindById(id));
        }


        [HttpPost]
        public IActionResult Create(Comment comment)
        {
            this._service.Create(comment);
            return Ok("Created");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            this._service.DeleteById(id);
            return Ok("Deleted");
        }

        [HttpPut]
        public IActionResult Update(string id, Comment comment)
        {
            this._service.UpdateComment(id, comment);
            return Ok("Updated");
        }
    }
}
