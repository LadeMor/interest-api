using System.Collections.Generic;
using System.Threading.Tasks;
using interest_api.Models;

namespace interest_api.Repositories
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> Get();
        Task<Post> Get(int id);
        Task<Post> Create(Post post);
        Task Update(Post post);
        Task Delete(int id);
    }
}