using System;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WEBAPIEF.Model;

namespace WEBAPIEF.Controllers
{
    [ApiController]
    [Route("post")]
    public class PostController : ControllerBase
    {

        private readonly ILogger<PostController> _logger;

        private readonly PostContext _context;

        public PostController(ILogger<PostController> logger, PostContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _context.postsss;
            return Ok(result);

        }

        [HttpGet("{id}")]
        public IActionResult GetById(int Id)
        {
            var result = _context.postsss.Find(Id);
            return Ok(result);

        }

        [HttpPost]
        public IActionResult PostAdd(Post posst)
        {
            _context.postsss.Add(posst);
            _context.SaveChanges();
            return Ok(posst);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePost(int Id)
        {
            var result = _context.postsss.Find(Id);
            _context.postsss.Remove(result);
            _context.SaveChanges();
            return Ok();

        }


        [HttpPatch("{id}")]
        public IActionResult UpdatePost([FromBody]JsonPatchDocument<Post> postss, int ID)
        {
            postss.ApplyTo(_context.postsss.Find(ID));
            return Ok(postss);

        }
    }
}
