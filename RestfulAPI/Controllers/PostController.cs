using Microsoft.AspNetCore.Mvc;
using RestfulAPI.Models;
using RestfulAPI.Service;

namespace RestfulAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        // Will be DTO applied
        [HttpPost]
        public IActionResult Create(Posts post)
        {
            var response = _postService.Create(post);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetPost(int id)
        {
            var response = _postService.GetPost(id);
            return Ok(response);
        }

        [HttpGet]
        public IActionResult GetAll(int id)
        {
            var response = _postService.GetPost(id);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePost(int id)
        {
            return Ok(_postService.DeleteProduct(id));
        }

        [HttpPut("{id}")]
        public IActionResult DeletePost(int id, Posts posts)
        {
            var response = _postService.Update(id, posts);
            return Ok(_postService.DeleteProduct(id));
        }
    }
}
