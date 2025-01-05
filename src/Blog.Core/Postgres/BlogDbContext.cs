using Blog.Models.Models.Request;
using Microsoft.EntityFrameworkCore;

namespace Blog.Core.Postgres
{
    public class BlogDbContext(DbContextOptions<BlogDbContext> options) : DbContext(options)
    {
        public DbSet<BlogRequest> Blogs { get; init; }
        public DbSet<UserRequestModel> Users { get; init; }
    }
}
