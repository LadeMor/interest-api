using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using interest_api.Databases;
using interest_api.Models;
using Microsoft.EntityFrameworkCore;

namespace interest_api.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly PostContext _context;

        public PostRepository(PostContext context)
        {
            _context = context;
        }
        
        public async Task<IEnumerable<Post>> Get()
        {
            return await _context.posts.ToListAsync();
        }

        public async Task<Post> Get(int id)
        {
            return await _context.posts.FindAsync(id);
        }

        public async Task<Post> Create(Post post)
        {
            _context.posts.Add(post);
            await _context.SaveChangesAsync();

            return post;
        }

        public async Task Update(Post post)
        {
            _context.Entry(post).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var postToDelete = await _context.posts.FindAsync(id);
            _context.posts.Remove(postToDelete);
            await _context.SaveChangesAsync();
        }
    }
}