using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using interest_api.Databases;
using interest_api.Models;
using interest_api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace interest_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepository;
        
        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Post>> GetPosts()
        {
            return await _postRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Post>> GetPosts(int id)
        {
            return await _postRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Post>> CreatePost(Post post)
        {
            return await _postRepository.Create(post);
        }

        [HttpDelete("{id}")]
        public void DeletePost(int id)
        {
            _postRepository.Delete(id);
        }
    }
}