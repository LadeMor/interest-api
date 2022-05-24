using interest_api.Models;
using Microsoft.EntityFrameworkCore;

namespace interest_api.Databases
{
    public class PostContext : DbContext
    {
        public PostContext(DbContextOptions<PostContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Post> posts { get; set; }
    }
}